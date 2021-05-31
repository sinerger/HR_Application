namespace HR_Application_DB_Logic.Models.Custom
{
    public class EmployeePositionDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public string HiderDate { get; set; }
        public string FiredDate { get; set; }
        public bool? IsActual { get; set; }
        public LevelsPositionDTO LevelPosition { get; set; }
        public PositionDTO Position { get; set; }
    }
}
