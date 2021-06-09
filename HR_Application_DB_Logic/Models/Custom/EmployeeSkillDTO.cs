namespace HR_Application_DB_Logic.Models.Custom
{
    public class EmployeeSkillDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public int SkillID { get; set; }
        public int LevelSkillID { get; set; }
        public string Date { get; set; }
        public bool? IsActual { get; set; }
        public int? UserID { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is EmployeeSkillDTO)
            {
                EmployeeSkillDTO employeeSkillDTO = (EmployeeSkillDTO)obj;

                if (employeeSkillDTO.ID == ID
                    && employeeSkillDTO.EmployeeID == EmployeeID
                    && employeeSkillDTO.Date == Date
                    && employeeSkillDTO.IsActual==IsActual
                    && employeeSkillDTO.UserID==UserID
                    && employeeSkillDTO.LevelSkillID==LevelSkillID
                    && employeeSkillDTO.SkillID==SkillID)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
