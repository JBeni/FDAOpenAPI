namespace FDAOpenAPI.WebUI.Controllers
{
    public class DrugsController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public DrugsController(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration["OpenFdaDrugEndpoint"])
            };
        }

        [HttpGet("drugs")]
        public async Task<IActionResult> GetData([FromQuery] int limitNumber)
        {
            var response = await _httpClient.GetAsync($"?limit={limitNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }
    }
}
