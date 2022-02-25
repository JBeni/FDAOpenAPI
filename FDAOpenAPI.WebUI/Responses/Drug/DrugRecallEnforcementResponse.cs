namespace FDAOpenAPI.WebUI.Responses.Drug
{
    public class DrugRecallEnforcementResponse
    {
        public Metadata Meta { get; set; }
        public List<DrugRecallEnforcementResult> Results { get; set; }
    }
}
