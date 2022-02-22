using FDAOpenAPI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FDAOpenAPI.WebUI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OpenFDAController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public OpenFDAController()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.fda.gov/")
            };
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetData()
        {
            var response = await _httpClient.GetAsync("drug/event.json?limit=10");
            var responseResult = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DrugModel>(
                responseResult,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return Ok(result);
        }
    }
}
