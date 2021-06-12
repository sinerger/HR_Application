using System.Collections.Generic;
using System.Linq;

namespace HR_Application_DB_Logic.Models.Base
{
    public class EmployeesProjectsDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public int?  ProjectID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool? IsActual { get; set; }


        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is EmployeesProjectsDTO)
            {
                EmployeesProjectsDTO employeesProjects = (EmployeesProjectsDTO)obj;

                if (employeesProjects.ID == ID
                    && employeesProjects.EmployeeID == EmployeeID
                    && employeesProjects.ProjectID == ProjectID
                    && employeesProjects.StartDate == StartDate
                    && employeesProjects.EndDate == EndDate
                    && employeesProjects.IsActual == IsActual)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
