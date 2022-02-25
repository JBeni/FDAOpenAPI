namespace FDAOpenAPI.WebUI.Responses.Food
{
    public class FoodRecallEnforcementResponse
    {
        public Metadata Meta { get; set; }
        public List<FoodRecallEnforcementResult> Results { get; set; }
    }
}
