using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models.Base
{
    public class CountryModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is CountryModel)
            {
                CountryModel country = (CountryModel)obj;

                if (country.ID == ID && country.Name == Name)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
