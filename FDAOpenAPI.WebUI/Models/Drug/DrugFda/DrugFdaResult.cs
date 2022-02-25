namespace FDAOpenAPI.WebUI.Models.Drug.DrugFda
{
    public class DrugFdaResult
    {
        public string Application_Number { get; set; }
        public OpenFda OpenFda { get; set; }
        public Products Products { get; set; }
        public string Sponsor_Name { get; set; }
        public Submissions Submissions { get; set; }
    }
}
