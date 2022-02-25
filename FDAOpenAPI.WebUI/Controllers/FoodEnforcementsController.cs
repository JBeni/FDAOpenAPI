namespace FDAOpenAPI.WebUI.Controllers
{
    public class FoodEnforcementsController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public FoodEnforcementsController(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration["OpenFdaFoodEndpoint"])
            };
        }

        [HttpGet("foods")]
        public async Task<IActionResult> GetData([FromQuery] int resultNumber)
        {
            var response = await _httpClient.GetAsync($"?limit={resultNumber}");
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
    }
}
