namespace FDAOpenAPI.WebUI.Models.Drug.AdverseEvent
{
    public class Patient
    {
        public List<Drug> Drug { get; set; }
        public string PatientAgeGroup { get; set; }
        public PatientDeath PatientDeath { get; set; }
        public string PatientOnSetAge { get; set; }
        public string PatientOnSetAgeUnit { get; set; }
        public string PatientSex { get; set; }
        public string PatientWeight { get; set; }
        public List<DrugAdverseReaction> Reaction { get; set; }
        public Summary Summary { get; set; }
        public string TransmissionDate { get; set; }
        public string Serious { get; set; }
        public string ReceiptDate { get; set; }
        public string PrimarySourceCountry { get; set; }
        public ReportDuplicate ReportDuplicate { get; set; }
    }
}
