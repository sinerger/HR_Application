using System.Collections.Generic;

namespace HR_Application_DB_Logic.Models.Base
{
    public class DepartmentProjectsDTO
    {
        public int? ID { get; set; }
        public int? DepartmentID { get; set; }
        public List<int> ProjectsID { get; set; }
        public bool? IsActual { get; set; }

        public override string ToString()
        {
            return $"DepartmentID:{DepartmentID}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is DepartmentProjectsDTO)
            {
                DepartmentProjectsDTO departmentProject = (DepartmentProjectsDTO)obj;

                if (departmentProject.ID == ID
                    && departmentProject.DepartmentID == DepartmentID
                    && departmentProject.ProjectsID.Equals(ProjectsID)
                    && departmentProject.IsActual == IsActual)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}