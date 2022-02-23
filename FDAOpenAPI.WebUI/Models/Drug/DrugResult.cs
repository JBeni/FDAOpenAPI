namespace FDAOpenAPI.WebUI.Models.Drug
{
    public class DrugResult
    {
        public string SafetyReportVersion { get; set; }
        public string SafetyReportId { get; set; }
        public string PrimarySourceCountry { get; set; }
        public string TransmissionDateFormat { get; set; }
        public string TransmissionDate { get; set; }
        public string ReportType { get; set; }
        public string Serious { get; set; }
        public string SeriousNessDisabling { get; set; }
        public string ReceiveDateFormat { get; set; }
        public string ReceiveDate { get; set; }
        public string ReceiptDateFormat { get; set; }
        public string ReceiptDate { get; set; }
        public string FulfillExpediteCriteria { get; set; }
        public string CompanyNumb { get; set; }
        public string Duplicate { get; set; }

        public ReportDuplicate ReportDuplicate { get; set; }
        public PrimarySource PrimarySource { get; set; }
        public Sender Sender { get; set; }
        public Receiver Receiver { get; set; }
        public Patient Patient { get; set; }
    }
}
