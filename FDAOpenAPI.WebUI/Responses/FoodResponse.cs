using FDAOpenAPI.WebUI.Models;

namespace FDAOpenAPI.WebUI.Responses
{
    public class FoodResponse
    {
        public Metadata Meta { get; set; }
        public List<FoodResult> Results { get; set; }
    }
}
