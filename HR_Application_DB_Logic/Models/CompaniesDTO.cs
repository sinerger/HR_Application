using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models
{
    public class CompaniesDTO
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public int? LocationID { get; set; }
        public string Description { get; set; }
        public bool? IsActual { get; set; }
    }
}
