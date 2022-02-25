namespace FDAOpenAPI.WebUI.Controllers
{
    public class DrugProductLabelingController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public DrugProductLabelingController(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration["OpenFdaDrugEndpoint"])
            };
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetProductLabelings([FromQuery] int resultNumber)
        {
            var response = await _httpClient.GetAsync($"label.json?limit={resultNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugProductLabelingResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("count-record")]
        public async Task<IActionResult> CountRecord([FromQuery] string search_field)
        {
            var response = await _httpClient.GetAsync($"label.json?count={search_field}.exact");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugProductLabelingCountResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("search-record")]
        public async Task<IActionResult> SearchRecord([FromQuery] string search_field, string search_value)
        {
            var response = await _httpClient.GetAsync($"label.json?search={search_field}:{search_value}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugProductLabelingResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }
    }
}
