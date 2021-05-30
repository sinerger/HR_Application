using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models
{
    public class EmployeeProjectsWithDirectionDTO
    {
        public int IDEmployeeProject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public int EmployeeID { get; set; }
        public List<int> ProjectsID { get; set; }
    }
}
