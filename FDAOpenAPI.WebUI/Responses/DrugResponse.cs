using FDAOpenAPI.WebUI.Models;

namespace FDAOpenAPI.WebUI.Responses
{
    public class DrugResponse
    {
        public Metadata Meta { get; set; }
        public List<DrugResult> Results { get; set; }
    }
}
