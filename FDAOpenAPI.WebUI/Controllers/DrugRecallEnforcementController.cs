namespace FDAOpenAPI.WebUI.Controllers
{
    public class DrugRecallEnforcementController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public DrugRecallEnforcementController(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration["OpenFdaDrugEndpoint"])
            };
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetRecallEnforcements([FromQuery] int resultNumber)
        {
            var response = await _httpClient.GetAsync($"enforcement.json?limit={resultNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugRecallEnforcementResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("search-health-hazard-class")]
        public async Task<IActionResult> SearchHealthHazardClass([FromQuery] string hazard_classes, int resultNumber)
        {
            var response = await _httpClient.GetAsync($"enforcement.json?search=classification:{hazard_classes.Replace("+", "")}&limit={resultNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugRecallEnforcementResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("count-search-field")]
        public async Task<IActionResult> CountBySearchField([FromQuery] string search_field)
        {
            var response = await _httpClient.GetAsync($"enforcement.json?count={search_field}.exact");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugRecallEnforcementCountResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }
    }
}
