namespace FDAOpenAPI.WebUI.Controllers
{
    public class FoodEnforcementsController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        //https://api.fda.gov/food/event.json?search=industry_name:"Snack Food Item"&limit=5

        public FoodEnforcementsController(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration["OpenFdaFoodEndpoint"])
            };
        }

        [HttpGet("foods")]
        public async Task<IActionResult> GetData([FromQuery] int limitNumber)
        {
            var response = await _httpClient.GetAsync($"?limit={limitNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<FoodRecallEnforcementResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("foods-count")]
        public async Task<IActionResult> GetCount([FromQuery] string search_field)
        {
            var response = await _httpClient.GetAsync($"?count={search_field}.exact");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<FoodRecallEnforcementCountResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetSearchData()
        {
            var response = await _httpClient.GetAsync($"?search=distribution_pattern:'nationwide'&limit=10");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<FoodRecallEnforcementResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("DownloadData")]
        public async Task<IActionResult> DownloadFoodData()
        {
            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://download.open.fda.gov/food/enforcement/food-enforcement-0001-of-0001.json.zip")
            };

            var response = await httpClient.GetAsync("");
            var responseResult = await response.Content.ReadAsStringAsync();

            return Ok();
        }






/*
        [HttpGet("tobaccos")]
        public async Task<IActionResult> GetData([FromQuery] int limitNumber)
        {
            var response = await _httpClient.GetAsync($"?limit={limitNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<TobaccoResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("tobaccos-search-by-field")]
        public async Task<IActionResult> SearchProblemByDateRange([FromQuery] string search_field, string value)
        {
            _ = long.TryParse(value, out long parseResult);
            string? query;
            if (parseResult == 0)
            {
                query = $"{search_field.ToLower()}:{value}";
            }
            else
            {
                query = $"{search_field.ToLower()}:{parseResult}";
            }

            var response = await _httpClient.GetAsync($"?search={query}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<TobaccoResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("tobaccos-by-date-range")]
        public async Task<IActionResult> SearchProblemByDateRange([FromQuery] DateTime startDate, DateTime endDate)
        {
            var response = await _httpClient.GetAsync($"?search=date_submitted:[{startDate.ToString("yyyy/MM/dd").Replace("/", "")}+TO+{endDate.ToString("yyyy/MM/dd").Replace("/", "")}]");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<TobaccoResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("tobaccos-count-by-field")]
        public async Task<IActionResult> CountTobaccosProduct([FromQuery] string search_field)
        {
            var response = await _httpClient.GetAsync($"?count={search_field.ToLower()}.exact");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<TobaccoCountResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }
*/

    }
}
