namespace FDAOpenAPI.WebUI.Models.Drug
{
    public class Patient
    {
        public string PatientOnSetAge { get; set; }
        public string PatientOnSetAgeUnit { get; set; }
        public string PatientSex { get; set; }
        public string TransmissionDate { get; set; }
        public string Serious { get; set; }
        public string ReceiptDate { get; set; }
        public string PrimarySourceCountry { get; set; }

        public ReportDuplicate ReportDuplicate { get; set; }
        public PatientDeath PatientDeath { get; set; }
        public List<DrugAdverseReaction> Reaction { get; set; }
        public List<Drug> Drug { get; set; }
    }
}