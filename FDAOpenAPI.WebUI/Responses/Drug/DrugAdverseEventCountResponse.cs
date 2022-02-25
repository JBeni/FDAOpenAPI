namespace FDAOpenAPI.WebUI.Responses.Drug
{
    public class DrugAdverseEventCountResponse
    {
        public Metadata Meta { get; set; }
        public List<CountModel> Results { get; set; }
    }
}
