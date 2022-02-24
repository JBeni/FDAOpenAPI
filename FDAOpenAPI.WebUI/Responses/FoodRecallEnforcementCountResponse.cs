namespace FDAOpenAPI.WebUI.Responses
{
    public class FoodRecallEnforcementCountResponse
    {
        public Metadata Meta { get; set; }
        public List<CountModel> Results { get; set; }
    }
}
