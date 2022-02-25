namespace FDAOpenAPI.WebUI.Controllers
{
    public class DrugAdverseEventsController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public DrugAdverseEventsController(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration["OpenFdaDrugEndpoint"])
            };
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAdverseEvents([FromQuery] int resultNumber)
        {
            var response = await _httpClient.GetAsync($"event.json?limit={resultNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugAdverseEventResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("search-pharmacologic-class")]
        public async Task<IActionResult> SearchPharmacologicClass([FromQuery] string pharmacologic_classes, int resultNumber)
        {
            string? query = string.Empty;
            if (pharmacologic_classes.Contains(' '))
            {
                foreach (var item in pharmacologic_classes.Split(" "))
                {
                    query += $"{item}+";
                }
            }
            if (pharmacologic_classes.Contains(','))
            {
                foreach (var item in pharmacologic_classes.Split(","))
                {
                    query += $"{item}+";
                }
            }

            var response = await _httpClient.GetAsync($"event.json?search=patient.drug.openfda.pharm_class_epc:{query}&limit={resultNumber}");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugAdverseEventResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("patient-reactions-count")]
        public async Task<IActionResult> GetPatientReactionsCount([FromQuery] string pharmacologic_classes, int resultNumber)
        {
            string? query = string.Empty;
            if (pharmacologic_classes.Contains(' '))
            {
                foreach (var item in pharmacologic_classes.Split(" "))
                {
                    query += $"{item}+";
                }
            }
            if (pharmacologic_classes.Contains(','))
            {
                foreach (var item in pharmacologic_classes.Split(","))
                {
                    query += $"{item}+";
                }
            }

            var response = await _httpClient.GetAsync($"event.json?search=patient.drug.openfda.pharm_class_epc:{query}&count=patient.reaction.reactionmeddrapt.exact");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugAdverseEventCountResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }

        [HttpGet("search-by-date-range")]
        public async Task<IActionResult> SearchByDateRange([FromQuery] string startDate, string endDate)
        {
            var response = await _httpClient.GetAsync($"event.json?search=receivedate:[{startDate.Replace("/", "")}+TO+{endDate.Replace("/", "")}]");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugAdverseEventResponse>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }
    }
}
