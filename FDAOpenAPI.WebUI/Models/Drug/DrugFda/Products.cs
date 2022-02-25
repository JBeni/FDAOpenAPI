namespace FDAOpenAPI.WebUI.Models.Drug.DrugFda
{
    public class Products
    {
        public ActiveIngredients Active_Ingredients { get; set; }
        public List<string> Brand_Name { get; set; }
        public string Dosage_Form { get; set; }
        public string Marketing_Status { get; set; }
        public string Product_Number { get; set; }
        public string Reference_Drug { get; set; }
        public string Reference_Standard { get; set; }
        public string Route { get; set; }
        public string Te_code { get; set; }
    }
}
