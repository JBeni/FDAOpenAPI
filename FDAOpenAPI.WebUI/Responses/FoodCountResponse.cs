using FDAOpenAPI.WebUI.Models;

namespace FDAOpenAPI.WebUI.Responses
{
    public class FoodCountResponse
    {
        public Metadata Meta { get; set; }
        public List<CountModel> Results { get; set; }
    }
}
