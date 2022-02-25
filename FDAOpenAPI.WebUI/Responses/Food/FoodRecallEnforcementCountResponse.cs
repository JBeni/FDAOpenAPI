namespace FDAOpenAPI.WebUI.Responses.Food
{
    public class FoodRecallEnforcementCountResponse
    {
        public Metadata Meta { get; set; }
        public List<CountModel> Results { get; set; }
    }
}
