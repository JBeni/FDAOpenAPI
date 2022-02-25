namespace FDAOpenAPI.WebUI.Controllers
{
    public class DrugNdcDirectoryController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public DrugNdcDirectoryController(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration["OpenFdaDrugEndpoint"])
            };
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetNdcDirectorys([FromQuery] int resultNumber)
        {
            var response = await _httpClient.GetAsync($"ndc.json?limit={resultNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugNdcDirectoryResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("search-product")]
        public async Task<IActionResult> SearchProduct([FromQuery] string search_field, string search_value, int resultNumber)
        {
            var response = await _httpClient.GetAsync($"ndc.json?search={search_field}:{search_value}&limit={resultNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugNdcDirectoryResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("search-dosage_form-product")]
        public async Task<IActionResult> SearchByDosageForm([FromQuery] string search_value, int resultNumber)
        {
            var response = await _httpClient.GetAsync($"ndc.json?search=dosage_form:{search_value}&limit={resultNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugNdcDirectoryResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("count-reactions-pharm-classes")]
        public async Task<IActionResult> CountPharmClasses([FromQuery] string pharm_classes)
        {
            var response = await _httpClient.GetAsync($"ndc.json?search=patient.drug.openfda.pharm_class_epc:{pharm_classes}&count=patient.reaction.reactionmeddrapt.exact");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugNdcDirectoryCountResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }
    }
}
