namespace FDAOpenAPI.WebUI.Responses.Drug
{
    public class DrugNdcDirectoryResponse
    {
        public Metadata Meta { get; set; }
        public List<DrugNdcDirectoryResult> Results { get; set; }
    }
}
