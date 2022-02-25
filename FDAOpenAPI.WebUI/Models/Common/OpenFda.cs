namespace FDAOpenAPI.WebUI.Models.Common
{
    public class OpenFda
    {
        public List<string> Application_Number { get; set; }
        public List<string> Brand_Name { get; set; }
        public List<string> Dosage_Form { get; set; }
        public List<string> Generic_Name { get; set; }
        public bool Is_Original_Packager { get; set; }
        public List<string> Manufacturer_Name { get; set; }
        public List<string> Nui { get; set; }
        public List<string> Original_Packager_Product_Ndc { get; set; }
        public List<string> Package_Ndc { get; set; }
        public List<string> Pharm_Class_Cs { get; set; }
        public List<string> Pharm_Class_Epc { get; set; }
        public List<string> Pharm_Class_Moa { get; set; }
        public List<string> Pharm_Class_Pe { get; set; }
        public List<string> Product_Ndc { get; set; }
        public List<string> Product_Type { get; set; }
        public List<string> Route { get; set; }
        public List<string> Rxcui { get; set; }
        public List<string> Rxstring { get; set; }
        public List<string> Rxtty { get; set; }
        public List<string> Spl_Id { get; set; }
        public List<string> Spl_Set_Id { get; set; }
        public List<string> Substance_Name { get; set; }
        public List<string> Unii { get; set; }
        public string Upc { get; set; }
    }
}
