namespace FDAOpenAPI.WebUI.Models.Drug.NdcDirectory
{
    public class DrugNdcDirectoryResult
    {
        public string Product_Id { get; set; }
        public string Product_Ndc { get; set; }
        public string Spl_Id { get; set; }
        public string Product_Type { get; set; }
        public string Finished { get; set; }
        public string Brand_Name { get; set; }
        public string Brand_Name_Base { get; set; }
        public string Brand_Name_Suffix { get; set; }
        public string Generic_Name { get; set; }
        public string Dosage_Form { get; set; }
        public string Route { get; set; }
        public string Marketing_Start_Date { get; set; }
        public string Marketing_End_Date { get; set; }
        public string Marketing_Category { get; set; }
        public string Application_Number { get; set; }
        public string Pharm_Class { get; set; }
        public string Dea_Schedule { get; set; }
        public string Listing_Expiration_Date { get; set; }
        public ActiveIngredients Active_Ingredients { get; set; }
        public Packaging Packaging { get; set; }
        public OpenFda OpenFda { get; set; }
    }
}
