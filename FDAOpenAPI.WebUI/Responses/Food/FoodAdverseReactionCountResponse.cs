namespace FDAOpenAPI.WebUI.Responses.Food
{
    public class FoodAdverseReactionCountResponse
    {
        public Metadata Meta { get; set; }
        public List<CountModel> Results { get; set; }
    }
}
