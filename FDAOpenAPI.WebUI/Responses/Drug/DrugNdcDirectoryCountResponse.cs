namespace FDAOpenAPI.WebUI.Responses.Drug
{
    public class DrugNdcDirectoryCountResponse
    {
        public Metadata Meta { get; set; }
        public List<CountModel> Results { get; set; }
    }
}
