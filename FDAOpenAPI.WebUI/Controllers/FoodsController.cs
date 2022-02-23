namespace FDAOpenAPI.WebUI.Controllers
{
    public class FoodsController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public FoodsController(IConfiguration configuration)
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
            var result = JsonSerializer.Deserialize<FoodResponse>(
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
            var result = JsonSerializer.Deserialize<FoodCountResponse>(
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
            var result = JsonSerializer.Deserialize<FoodResponse>(
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
    }
}
