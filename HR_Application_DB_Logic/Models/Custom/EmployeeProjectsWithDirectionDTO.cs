using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models
{
    public class EmployeeProjectsWithDirectionDTO
    {
        public int IDEmployeeProject { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int EmployeeID { get; set; }
        public List<int> ProjectsID { get; set; }
    }
}
