using HR_Application_BLL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models
{
    public class Adress
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public int HourseNumber { get; set; }
        public string Block { get; set; }
        public int ApartmentNumber { get; set; }
        public int PostIndex { get; set; }
        public int CityID { get; set; }
        public CityModel City { get; set; }
        public CountryModel Country { get; set; }

        public Adress()
        {
            City = new CityModel();
            Country = new CountryModel();
        }

        public override string ToString()
        {
            return $"Adress: {Country} {City} {Street}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Adress)
            {
                Adress adress = (Adress)obj;

                if (adress.ID == ID
                    && adress.Street == Street
                    && adress.HourseNumber == HourseNumber
                    && adress.Block == Block
                    && adress.ApartmentNumber == ApartmentNumber
                    && adress.PostIndex == PostIndex
                    && adress.Country.Equals(Country) 
                    && adress.City.Equals(City))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}