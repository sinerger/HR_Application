using System.Collections.Generic;

namespace HR_Application_DB_Logic.Models.Custom
{
    public class CompanyDepartmentsDTO
    {
        public int? ID { get; set; }
        public int? CompanyID { get; set; }
        public List<DepartmentDTO> Departments { get; set; }
    }
}
