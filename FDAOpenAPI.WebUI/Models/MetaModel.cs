namespace FDAOpenAPI.WebUI.Models
{
    public class MetaModel
    {
        public string Disclaimer { get; set; }
        public string Terms { get; set; }
        public string License { get; set; }
        public DateTime Last_Updated { get; set; }

        public PagingModel Results { get; set; }
    }
}
