using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models.Custom
{
    class CompaniesDepartmentsDTO
    {
        public int? IDCompany { get; set; }
        public string CompanyDescription { get; set; }
        public string CompanyTitle { get; set; }
        public int? IDCompany_Location { get; set; }
        public int? LocationID { get; set; }
        public int? IDCompanies_Depatments { get; set; }
        public DepartmentDTO Department { get; set; }
    }
}
