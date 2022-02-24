using FDAOpenAPI.WebUI.Models.Food.RecallEnforcement;

namespace FDAOpenAPI.WebUI.Responses
{
    public class FoodRecallEnforcementResponse
    {
        public Metadata Meta { get; set; }
        public List<FoodRecallEnforcementResult> Results { get; set; }
    }
}
