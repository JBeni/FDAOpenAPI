namespace FDAOpenAPI.WebUI.Responses.Drug
{
    public class DrugRecallEnforcementCountResponse
    {
        public Metadata Meta { get; set; }
        public List<CountModel> Results { get; set; }
    }
}
