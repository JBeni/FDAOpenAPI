namespace FDAOpenAPI.WebUI.Models
{
    public class ResultsModel
    {
        public string ReceiptDateFormat { get; set; }
        public string Receiver { get; set; }
        public string SeriousNessDeath { get; set; }
        public string CompanyNumb { get; set; }
        public string ReceiveDateFormat { get; set; }

        public Company PrimarySource { get; set; }
        public string TransmissionDateFormat { get; set; }
        public string FulfillExpediteCriteria { get; set; }
        public string SafetyReportId { get; set; }
        public SenderCompany Sender { get; set; }
        public string ReceiveDate { get; set; }
        public Patient Patient { get; set; }

        public string TransimissionDate { get; set; }
        public string Serious { get; set; }
        public string ReceiptDate { get; set; }
    }
}

public class Patient
{
    public string PatientOnSetAge { get; set; }
    public string PatientOnSetAgeUnit { get; set; }
    public string PatientSex { get; set; }
    public PatientDeath PatientDeath { get; set; }

    public List<DrugReaction> Reaction { get; set; }
    public List<Drug> Drug { get; set; }

    public string TransmissionDate { get; set; }
    public string Serious { get; set; }
    public ReportDuplicate ReportDuplicate { get; set; }
    public string ReceiptDate { get; set; }
    public string PrimarySourceCountry { get; set; }
}

public class PatientDeath
{
    public string PatientDeathDateFormat { get; set; }
    public string PatientDeathDate { get; set; }
}

public class SenderCompany
{
    public string SenderType { get; set; }
    public string SenderOrganization { get; set; }
}

public class ReceiverCompany
{
    public string ReceiverType { get; set; }
    public string ReceiverOrganization { get; set; }
}


public class Company
{
    public string ReporterCountry { get; set; }
    public string Qualification { get; set; }
}

public class DrugReaction
{
    public string ReactionMedDraVersionpt { get; set; }
    public string ReactionMedDrapt { get; set; }
}

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
    public OpenFDA OpenFDA { get; set; }
}

public class OpenFDA
{
    public List<string> Application_Number { get; set; }
    public List<string> Brand_Name { get; set; }
    public List<string> Generic_Name { get; set; }
    public List<string> Manufacturer_Name { get; set; }
    public List<string> Product_Ndc { get; set; }
    public List<string> Product_Type { get; set; }
    public List<string> Route { get; set; }
    public List<string> Substance_Name { get; set; }
    public List<string> Rxcui { get; set; }
    public List<string> Spl_Id { get; set; }
    public List<string> Spl_Set_Id { get; set; }
    public List<string> Package_Ndc { get; set; }
    public List<string> Nui { get; set; }
    public List<string> Pharm_Class_Moa { get; set; }
    public List<string> Pharm_Class_Cs { get; set; }
    public List<string> Pharm_Class_Epc { get; set; }
    public List<string> Unii { get; set; }
}


