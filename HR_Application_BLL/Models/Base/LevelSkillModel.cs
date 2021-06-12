using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models.Base
{
    public class LevelSkillModel
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public LevelSkillModel Clone()
        {
            return new LevelSkillModel()
            {
                ID = ID,
                Title = Title
            };
        }

        public override string ToString()
        {
            return Title;
        }
        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is LevelSkillModel)
            {
                LevelSkillModel levelSkill = (LevelSkillModel)obj;

                if (levelSkill.ID == ID
                    && levelSkill.Title == Title)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
