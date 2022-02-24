using FDAOpenAPI.WebUI.Models.Food.AdverseReaction;

namespace FDAOpenAPI.WebUI.Responses
{
    public class FoodAdverseReactionResponse
    {
        public Metadata Meta { get; set; }
        public List<FoodAdverseReactionResult> Results { get; set; }
    }
}
