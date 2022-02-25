namespace FDAOpenAPI.WebUI.Responses.Drug
{
    public class DrugFdaResponse
    {
        public Metadata Meta { get; set; }
        public List<DrugFdaResult> Results { get; set; }
    }
}
