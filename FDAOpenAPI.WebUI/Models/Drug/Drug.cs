namespace FDAOpenAPI.WebUI.Models.Drug
{
    public class Drug
    {
        public string DrugCharacterization { get; set; }
        public string MedicinalProduct { get; set; }
        public string DrugBatchNumb { get; set; }
        public string DrugAuthorizationNumb { get; set; }
        public string DrugStructureDosageNumb { get; set; }
        public string DrugStructureDosageUnit { get; set; }
        public string DrugDosageText { get; set; }
        public string DrugAdministrationRoute { get; set; }
        public string DrugIndication { get; set; }
        public string DrugStartDateFormat { get; set; }
        public string DrugStartDate { get; set; }
        public OpenFda OpenFda { get; set; }
    }
}
