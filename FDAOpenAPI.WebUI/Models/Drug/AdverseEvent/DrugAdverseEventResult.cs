namespace FDAOpenAPI.WebUI.Models.Drug.AdverseEvent
{
    public class DrugAdverseEventResult
    {
        public string AuthorityNumb { get; set; }
        public string CompanyNumb { get; set; }
        public string Duplicate { get; set; }
        public string FullFillExpediteCriteria { get; set; }
        public string OccurCountry { get; set; }
        public Patient Patient { get; set; }
        public PrimarySource PrimarySource { get; set; }
        public string PrimarySourceCountry { get; set; }
        public string ReceiptDate { get; set; }
        public string ReceiptDateFormat { get; set; }
        public string ReceiveDate { get; set; }
        public string ReceiveDateFormat { get; set; }
        public Receiver Receiver { get; set; }
        public ReportDuplicate ReportDuplicate { get; set; }
        public string ReportType { get; set; }
        public string SafetyReportId { get; set; }
        public string SafetyReportVersion { get; set; }
        public Sender Sender { get; set; }
        public string Serious { get; set; }
        public string SeriousnessCongenitalAnomali { get; set; }
        public string SeriousnessDeath { get; set; }
        public string SeriousnessDisabling { get; set; }
        public string SeriousnessHospitalization { get; set; }
        public string SeriousnessLifeThreatening { get; set; }
        public string SeriousnessOther { get; set; }
        public string TransmissionDate { get; set; }
        public string TransmissionDateFormat { get; set; }
    }
}
