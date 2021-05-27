using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models
{
    public class CityDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public CountryDTO Country { get; set; }
    }
}
