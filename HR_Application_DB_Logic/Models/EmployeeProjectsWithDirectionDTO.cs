using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models
{
    public class EmployeeProjectsWithDirectionDTO
    {
        public int? ID { get; set; }
        public string Photo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegistationDate { get; set; }
        public ProjectDTO Project { get; set; }
        public DirectionDTO Direction { get; set; }
        public bool IsActual { get; set; }
    }
}
