using System.Collections.Generic;

namespace HR_Application_DB_Logic.Models.Custom
{
    public class CompanyDepartmentsDTO
    {
        public CompanyDTO Company { get; set; }
        public List<DepartmentDTO> Departments { get; set; }
    }
}
