using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models
{
    public class RequirementDTO
    {
        public int? ID { get; set; }
        public int? SkillID { get; set; }
        public int? LevelSkillID { get; set; }
        public int? AmountOfEmployees { get; set; }
    }
}
