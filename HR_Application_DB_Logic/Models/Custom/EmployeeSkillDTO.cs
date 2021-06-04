namespace HR_Application_DB_Logic.Models.Custom
{
    public class EmployeeSkillDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public string Date { get; set; }
        public bool? IsActual { get; set; }
        public int? UserID { get; set; }
        public int LevelID { get; set; }
        public int SkillID { get; set; }
    }
}
