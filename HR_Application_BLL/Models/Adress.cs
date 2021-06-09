using HR_Application_BLL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models
{
    public class Adress
    {
        public LocationModel Location { get; set; }
        public CityModel City { get; set; }
        public CountryModel Country { get; set; }

        public override string ToString()
        {
            return $"Adress: {Country} {City} {Location}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Adress)
            {
                Adress adress = (Adress)obj;

                if (adress.Location.Equals(Location) && adress.Country.Equals(Country) && adress.City.Equals(City))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}