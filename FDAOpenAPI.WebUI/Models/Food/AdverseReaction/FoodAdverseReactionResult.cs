namespace FDAOpenAPI.WebUI.Models.Food.AdverseReaction
{
    public class FoodAdverseReactionResult
    {
        public Consumer Consumer { get; set; }
        public string Date_Created { get; set; }
        public string Date_Started { get; set; }
        public List<string> Outcomes { get; set; }
        public Products Products { get; set; }
        public List<string> Reactions { get; set; }
        public string Report_Number { get; set; }
    }
}
