using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models.Base
{
    public class CityModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is CityModel)
            {
                CityModel city = (CityModel)obj;

                if (city.ID == ID
                    && city.Name == Name
                    && city.CountryID == CountryID)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
