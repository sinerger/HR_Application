using HR_Application_BLL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models
{
    public class Competence
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string Data { get; set; }
        public SkillModel Skill { get; set; }
        public LevelSkillModel LevelSkill { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Competence)
            {
                Competence competence = (Competence)obj;

                if (competence.ID == ID
                    && competence.EmployeeID == EmployeeID
                    && competence.Data == Data
                    && competence.Skill == Skill
                    && competence.LevelSkill == LevelSkill
                    && competence.Equals(competence))
                {
                    result = true;
                }
            }

            return result;
        }

        public override string ToString()
        {
            return $"Competence skill:{Skill.Title}, Level:{LevelSkill.Title}";
        }

    }
}

