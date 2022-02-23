namespace FDAOpenAPI.WebUI.Models.Common
{
    public class Metadata
    {
        public string Disclaimer { get; set; }
        public string Terms { get; set; }
        public string License { get; set; }
        public DateTime Last_Updated { get; set; }

        public MetadataPaging Results { get; set; }
    }
}
