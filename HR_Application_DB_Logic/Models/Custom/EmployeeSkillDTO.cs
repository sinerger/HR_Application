using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeeSkillDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public string Date { get; set; }
        public bool? IsActual { get; set; }
        public int? UserID { get; set; }
        public LevelSkillDTO Level { get; set; }
        public SkillDTO Skill { get; set; }
    }
}
