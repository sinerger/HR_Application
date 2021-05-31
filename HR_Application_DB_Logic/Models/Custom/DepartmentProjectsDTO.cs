using System.Collections.Generic;

namespace HR_Application_DB_Logic.Models.Custom
{
    public class DepartmentProjectsDTO
    {
        public int ID { get; set; }
        public DepartmentDTO Department { get; set; }
        public List<int> ProjectsID { get; set; }
    }
}
