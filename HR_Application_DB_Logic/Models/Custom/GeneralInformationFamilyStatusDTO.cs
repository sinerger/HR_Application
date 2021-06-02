namespace HR_Application_DB_Logic.Models.Custom
{
    public class GeneralInformationFamilyStatusDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public string Sex { get; set; }
        public string Education { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string Hobby { get; set; }
        public int? AmountChildren { get; set; }
        public FamilyStatusDTO FamilyStatus { get; set; }
    }
}