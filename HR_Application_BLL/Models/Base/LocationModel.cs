using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models.Base
{
    public class LocationModel
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public string Street { get; set; }
        public int HourseNumber { get; set; }
        public string Block { get; set; }
        public int ApartmentNumber { get; set; }
        public int PostIndex { get; set; }

        public override string ToString()
        {
            return $"{Street} h.{HourseNumber} a.{ApartmentNumber}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is LocationModel)
            {
                LocationModel location = (LocationModel)obj;

                if (location.ID == ID
                    && location.CityID == CityID
                    && location.Street == Street
                    && location.HourseNumber == HourseNumber
                    && location.Block == Block
                    && location.ApartmentNumber == ApartmentNumber
                    && location.PostIndex == PostIndex)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
