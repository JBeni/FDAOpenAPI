namespace FDAOpenAPI.WebUI.Controllers
{
    public class FoodAdverseEventsController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        //https://api.fda.gov/food/enforcement.json?search=distribution_pattern:"nationwide"&limit=5

        public FoodAdverseEventsController(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration["OpenFdaFoodEndpoint"])
            };
        }

        [HttpGet("adverse-reactions")]
        public async Task<IActionResult> GetData([FromQuery] int limitNumber)
        {
            var response = await _httpClient.GetAsync($"event.json?limit={limitNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<FoodRecallEnforcementResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("adverse-reactions-count")]
        public async Task<IActionResult> GetCount([FromQuery] string search_field, string value)
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

            var response = await _httpClient.GetAsync($"event.json?search={query}&count=reactions.exact");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<FoodRecallEnforcementCountResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("adverse-reactions-search-by-field")]
        public async Task<IActionResult> GetSearchField([FromQuery] string search_field, string value, int limitNumber)
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

            var response = await _httpClient.GetAsync($"event.json?search={query}&limit={limitNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<FoodRecallEnforcementResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("adverse-reactions-search-by-date-range")]
        public async Task<IActionResult> GetSearchByDateRange([FromQuery] string startDate, string endDate)
        {
            var response = await _httpClient.GetAsync($"?search=date_started:[{startDate.Replace("/", "")}+TO+{endDate.Replace("/", "")}]");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<FoodRecallEnforcementResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }
    }
}
