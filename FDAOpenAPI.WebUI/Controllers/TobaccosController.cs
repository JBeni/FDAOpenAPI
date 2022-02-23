namespace FDAOpenAPI.WebUI.Controllers
{
    public class TobaccosController : ApiControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public TobaccosController(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_configuration["OpenFdaTobaccoEndpoint"])
            };
        }

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
    }
}
