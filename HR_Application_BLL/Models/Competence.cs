﻿using HR_Application_BLL.Models.Base;
using System.Linq;

namespace HR_Application_BLL.Models
{
    public class Competence
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string Date { get; set; }
        public int UserID { get; set; }
        public SkillModel Skill { get; set; }
        public LevelSkillModel LevelSkill { get; set; }

        public override string ToString()
        {
            return $"{Skill} {LevelSkill} - {Date}";
        }
        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Competence)
            {
                Competence competence = (Competence)obj;

                if (competence.ID == ID
                    && competence.EmployeeID == EmployeeID
                    && competence.Date == Date)
                {
                    if (competence.Skill != null && competence.Skill.Equals(Skill))
                    {
                        if (competence.LevelSkill != null && competence.LevelSkill.Equals(LevelSkill))
                        {
                            result = true;
                        }
                    }
                    else if (competence.Skill == null && Skill == null)
                    {
                        if (competence.LevelSkill == null && LevelSkill == null)
                        {
                            result = true;
                        }
                    }
                }
            }

            return result;
        }
    }
}

