namespace FDAOpenAPI.WebUI.Responses.Drug
{
    public class DrugProductLabelingResponse
    {
        public Metadata Meta { get; set; }
        public List<DrugProductLabelingResult> Results { get; set; }
    }
}
