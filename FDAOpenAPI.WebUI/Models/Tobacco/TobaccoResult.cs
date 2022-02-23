namespace FDAOpenAPI.WebUI.Models.Tobacco
{
    public class TobaccoResult
    {
        public string Date_Submitted { get; set; }
        public string NonUser_Affected { get; set; }
        public List<string> Reported_Health_Problems { get; set; }
        public long Number_Tobacco_Products { get; set; }
        public long Report_Id { get; set; }
        public long Number_Health_Problems { get; set; }
        public List<string> Reported_Product_Problems { get; set; }
        public List<string> Tobacco_Products { get; set; }
        public long Number_Product_Problems { get; set; }
    }
}
