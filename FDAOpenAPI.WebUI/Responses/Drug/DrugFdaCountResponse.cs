namespace FDAOpenAPI.WebUI.Responses.Drug
{
    public class DrugFdaCountResponse
    {
        public Metadata Meta { get; set; }
        public List<CountModel> Results { get; set; }
    }
}
