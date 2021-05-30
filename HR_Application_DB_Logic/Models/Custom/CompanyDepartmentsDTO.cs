using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models.Custom
{
    public class CompanyDepartmentsDTO
    {
        public CompanyDTO Company { get; set; }
        public List<DepartmentDTO> Departments { get; set; }
    }
}
