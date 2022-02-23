using FDAOpenAPI.WebUI.Models;

namespace FDAOpenAPI.WebUI.Responses
{
    public class DrugCountResponse
    {
        public Metadata Meta { get; set; }
        public List<CountModel> Results { get; set; }
    }
}
