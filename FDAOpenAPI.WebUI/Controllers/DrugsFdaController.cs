namespace FDAOpenAPI.WebUI.Controllers
{
    public class DrugsFdaController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public DrugsFdaController(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration["OpenFdaDrugEndpoint"])
            };
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetDrugsFda([FromQuery] int resultNumber)
        {
            var response = await _httpClient.GetAsync($"drugsfda.json?limit={resultNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugFdaResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("search-dosage_form-product")]
        public async Task<IActionResult> SearchByDosageForm([FromQuery] string search_value, int resultNumber)
        {
            var response = await _httpClient.GetAsync($"drugsfda.json?search=products.dosage_form:{search_value}&limit={resultNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugFdaResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("count-search-field")]
        public async Task<IActionResult> CountBySearchField([FromQuery] string search_field)
        {
            var response = await _httpClient.GetAsync($"drugsfda.json?count={search_field}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugFdaCountResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }
    }
}
