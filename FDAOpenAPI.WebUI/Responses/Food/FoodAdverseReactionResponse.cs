namespace FDAOpenAPI.WebUI.Responses.Food
{
    public class FoodAdverseReactionResponse
    {
        public Metadata Meta { get; set; }
        public List<FoodAdverseReactionResult> Results { get; set; }
    }
}
