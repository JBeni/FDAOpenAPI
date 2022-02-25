namespace FDAOpenAPI.WebUI.Models.Drug.AdverseEvent
{
    public class Drug
    {
        public string ActionDrug { get; set; }
        public ActiveSubstance ActiveSubstance { get; set; }
        public string DrugAdditional { get; set; }
        public string DrugAdministrationRoute { get; set; }
        public string DrugAuthorizationNumb { get; set; }
        public string DrugBatchNumb { get; set; }
        public string DrugCharacterization { get; set; }
        public string DrugCumulativeDosageNumb { get; set; }
        public string DrugCumulativeDosageUnit { get; set; }
        public string DrugDosageForm { get; set; }
        public string DrugDosageText { get; set; }
        public string DrugendDate { get; set; }
        public string DrugendDateFormat { get; set; }
        public string DrugIndication { get; set; }
        public string DrugIntervalDosageDefinition { get; set; }
        public string DrugIntervalDosageUnitNumb { get; set; }
        public string DrugRecurreAdministration { get; set; }
        public string DrugRecurrence { get; set; }
        public string DrugSeparateDosageNumb { get; set; }
        public string DrugStartDateFormat { get; set; }
        public string DrugStartDate { get; set; }
        public string DrugStructureDosageNumb { get; set; }
        public string DrugStructureDosageUnit { get; set; }
        public string DrugTreatmentDuration { get; set; }
        public string DrugTreatmentDurationUnit { get; set; }
        public string MedicinalProduct { get; set; }
        public OpenFda OpenFda { get; set; }
    }
}
