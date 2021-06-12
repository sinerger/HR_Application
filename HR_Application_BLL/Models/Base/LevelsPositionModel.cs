using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models.Base
{
  public  class LevelsPositionModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            return $"{Title}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is LevelsPositionModel)
            {
                LevelsPositionModel levelsPosition = (LevelsPositionModel)obj;

                if (levelsPosition.ID == ID
                    && levelsPosition.Title == Title
                    && levelsPosition.Description == Description)
                { 
                    result = true;
                }
            }

            return result;
        }
    }
}