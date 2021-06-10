namespace HR_Application_DB_Logic.Models
{
    public class EmployeePositionDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public string HiderDate { get; set; }
        public string FiredDate { get; set; }
        public bool? IsActual { get; set; }
        public int? LevelPositionID { get; set; }
        public int? PositionID { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is EmployeePositionDTO)
            {
                EmployeePositionDTO employeePositionDTO = (EmployeePositionDTO)obj;
        
                if (employeePositionDTO.ID == ID
                    && employeePositionDTO.EmployeeID == EmployeeID
                    && employeePositionDTO.HiderDate == HiderDate
                    && employeePositionDTO.FiredDate == FiredDate
                    && employeePositionDTO.IsActual == IsActual
                    && employeePositionDTO.LevelPositionID.Equals(LevelPositionID)
                    && employeePositionDTO.PositionID.Equals(PositionID))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
