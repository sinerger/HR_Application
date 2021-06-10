using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Base.Models
{
  public class EmployeePositionModel
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string HiderDate { get; set; }
        public string FiredDate { get; set; }
        public bool IsActual { get; set; }
        public int LevelPositionID { get; set; }
        public int PositionID { get; set; }

        public override string ToString()
        {
            return $"{EmployeeID} {HiderDate}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is EmployeePositionModel)
            {
                EmployeePositionModel employeePosition = (EmployeePositionModel)obj;
                if (employeePosition.ID == ID
                   && employeePosition.EmployeeID == EmployeeID
                   && employeePosition.HiderDate == HiderDate
                   && employeePosition.FiredDate == FiredDate
                   && employeePosition.IsActual == IsActual
                   && employeePosition.LevelPositionID.Equals(LevelPositionID)
                   && employeePosition.PositionID.Equals(PositionID))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
