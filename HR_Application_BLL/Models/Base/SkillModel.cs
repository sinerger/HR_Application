using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models.Base
{
    public class SkillModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public SkillModel Clone()
        {
            return new SkillModel()
            {
                ID = ID,
                Title = Title,
                Description = Description
            };
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is SkillModel)
            {
                SkillModel skill = (SkillModel)obj;

                if (skill.ID == ID
                    && skill.Title == Title
                    && skill.Description == Description)
                {
                    result = true;
                }
            }

            return result;
        }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
