using FDAOpenAPI.WebUI.Models;

namespace FDAOpenAPI.WebUI.Responses
{
    public class TobaccoResponse
    {
        public Metadata Meta { get; set; }
        public List<TobaccoResult> Results { get; set; }
    }
}
