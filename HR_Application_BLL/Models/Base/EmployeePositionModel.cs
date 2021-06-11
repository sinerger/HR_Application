namespace HR_Application_BLL.Base.Models
{
  public class EmployeePositionModel
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int PositionID { get; set; }
        public string HiredDate { get; set; }
        public string FiredDate { get; set; }
        public bool IsActual { get; set; }
        public int LevelsPosition { get; set; }

        public override string ToString()
        {
            return $"EmployeeID:{EmployeeID} , HiderDate:{HiredDate}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is EmployeePositionModel)
            {
                EmployeePositionModel employeePosition = (EmployeePositionModel)obj;
                if (employeePosition.ID == ID
                   && employeePosition.EmployeeID == EmployeeID
                   && employeePosition.HiredDate == HiredDate
                   && employeePosition.FiredDate == FiredDate
                   && employeePosition.IsActual == IsActual
                   && employeePosition.LevelsPosition == LevelsPosition
                   && employeePosition.PositionID == PositionID)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}