using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models
{
    public class LocationDTO
    {
        public int? ID { get; set; }
        public int? CityID { get; set; }
        public string Street { get; set; }
        public int? HourseNumber { get; set; }
        public string Block { get; set; }
        public int? ApartmentNumber { get; set; }
        public int? PostIndex { get; set; }
    }
}
