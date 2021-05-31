using System.Collections.Generic;

namespace HR_Application_DB_Logic.Models.Custom
{
    public class CompanyDepartmentsDTO
    {
        public int? IDCompanyDepartments { get; set; }
        public CompanyDTO Company { get; set; }
        public List<int> DepartmentsID { get; set; }
    }
}
