using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models
{
     public class EmployeeSkillModel
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int SkillID { get; set; }
        public int LevelSkillID { get; set; }
        public string Date { get; set; }
        public bool IsActual { get; set; }
        public int UserID { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is EmployeeSkillModel)
            {
                EmployeeSkillModel employeeSkill = (EmployeeSkillModel)obj;

                if (employeeSkill.ID == ID
                    && employeeSkill.EmployeeID == EmployeeID
                    && employeeSkill.Date == Date
                    && employeeSkill.IsActual == IsActual
                    && employeeSkill.UserID == UserID
                    && employeeSkill.LevelSkillID == LevelSkillID
                    && employeeSkill.SkillID == SkillID)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
