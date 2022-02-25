namespace FDAOpenAPI.WebUI.Responses.Drug
{
    public class DrugAdverseEventResponse
    {
        public Metadata Meta { get; set; }
        public List<DrugAdverseEventResult> Results { get; set; }
    }
}
