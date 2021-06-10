using System.Collections.Generic;
using System.Linq;
namespace HR_Application_BLL.Models.Base
{
    public class DepartmentProjectsModel
    {
        public int ID { get; set; }
        public int DepartmentID { get; set; }
        public List<int> ProjectsID { get; set; }
        public bool IsActual { get; set; }

        public override string ToString()
        {
            return $"DepartmentID:{DepartmentID}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is DepartmentProjectsModel)
            {
                DepartmentProjectsModel departmentProject = (DepartmentProjectsModel)obj;

                if (departmentProject.ID == ID
                    && departmentProject.DepartmentID == DepartmentID
                    && departmentProject.ProjectsID.SequenceEqual(ProjectsID)
                    && departmentProject.IsActual == IsActual)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}