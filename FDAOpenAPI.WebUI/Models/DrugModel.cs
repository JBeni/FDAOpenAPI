namespace FDAOpenAPI.WebUI.Models
{
    public class DrugModel
    {
        public MetaModel Meta { get; set; }
        
        //public List<ResultsModel> Results { get; set; }
        
        public List<DrugResult> Results { get; set; }
    }
}

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
    public Company PrimarySource { get; set; }
    public SenderCompany Sender { get; set; }
    public ReceiverCompany Receiver { get; set; }
    public PatientData Patient { get; set; }

}

public class PatientData
{
    public string PatientOnSetAge { get; set; }
    public string PatientOnSetAgeUnit { get; set; }
    public string PatientSex { get; set; }
    public PatientDeath PatientDeath { get; set; }

    public List<DrugReaction> Reaction { get; set; }
    public List<Drug> Drug { get; set; }
}


public class ReportDuplicate
{
    public string DuplicateSource { get; set; }
    public string DuplicateNumb { get; set; }
}


