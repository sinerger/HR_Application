namespace HR_Application_DB_Logic.Models
{
    public class EmployeePositionDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public int? PositionID { get; set; }
        public string HiredDate { get; set; }
        public string FiredDate { get; set; }
        public bool? IsActual { get; set; }
        public int? LevelPositionID { get; set; }

        public override string ToString()
        {
            return $"EmployeeID:{EmployeeID} , HiderDate:{HiredDate}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is EmployeePositionDTO)
            {
                EmployeePositionDTO employeePositionDTO = (EmployeePositionDTO)obj;
        
                if (employeePositionDTO.ID == ID
                    && employeePositionDTO.EmployeeID == EmployeeID
                    && employeePositionDTO.HiredDate == HiredDate
                    && employeePositionDTO.FiredDate == FiredDate
                    && employeePositionDTO.IsActual == IsActual
                    && employeePositionDTO.LevelPositionID == LevelPositionID
                    && employeePositionDTO.PositionID == PositionID)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}