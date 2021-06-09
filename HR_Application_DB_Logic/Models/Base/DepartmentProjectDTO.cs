using System.Collections.Generic;

namespace HR_Application_DB_Logic.Models.Base
{
    public class DepartmentProjectDTO
    {
        public int? ID { get; set; }
        public int? DepartmentID { get; set; }
        public List<int> ProjectID { get; set; }
        public bool? IsActual { get; set; }

        public override string ToString()
        {
            return $"DepartmentID:{DepartmentID} ProjectID:{ProjectID} IsActual:{IsActual}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is DepartmentProjectDTO)
            {
                DepartmentProjectDTO departmentProject = (DepartmentProjectDTO)obj;

                if (departmentProject.ID == ID
                    && departmentProject.DepartmentID == DepartmentID
                    && departmentProject.ProjectID.Equals(ProjectID)
                    && departmentProject.IsActual == IsActual)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}