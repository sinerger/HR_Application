using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models.Base
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string Photo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegistrationDate { get; set; }
        public int StatusID { get; set; }
        public int LocationID { get; set; }
        public bool IsActual { get; set; }

        public override string ToString()
        {
            return $"FirstName:{FirstName} LastName{LastName} RegistrationDate{RegistrationDate.ToString()}";
        }
        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is EmployeeModel)
            {
                EmployeeModel employeeModel = (EmployeeModel)obj;

                if (employeeModel.ID == ID
                    && employeeModel.Photo == Photo
                    && employeeModel.FirstName == FirstName
                    && employeeModel.LastName == LastName
                    && employeeModel.RegistrationDate == RegistrationDate
                    && employeeModel.StatusID == StatusID
                    && employeeModel.LocationID == LocationID
                    && employeeModel.IsActual == IsActual)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
