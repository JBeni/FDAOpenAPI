namespace FDAOpenAPI.WebUI.Models.Drug.DrugFda
{
    public class Submissions
    {
        public SubmissionPropertyType Submission_Property_Type { get; set; }
        public ApplicationDocs Application_Docs { get; set; }
        public string Review_Priority { get; set; }
        public string Submission_Class_Code { get; set; }
        public string Submission_Class_Code_Description { get; set; }
        public string Submission_Number { get; set; }
        public string Submission_Public_Notes { get; set; }
        public string Submission_Status { get; set; }
        public string Submission_Status_Date { get; set; }
        public string Submission_Type { get; set; }
    }
}
