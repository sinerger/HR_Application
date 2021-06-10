using System.Collections.Generic;
using System.Linq;

namespace HR_Application_DB_Logic.Models.Base
{
    public class CompanyDepartmentsDTO
    {
        public int? ID { get; set; }
        public int? CompanyID { get; set; }
        public bool? IsActual { get; set; }
        public List<int> DepartmentsID { get; set; }

        public override string ToString()
        {
            return $"CompanyID:{CompanyID}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is CompanyDepartmentsDTO)
            {
                CompanyDepartmentsDTO companyDepartments = (CompanyDepartmentsDTO)obj;

                if (companyDepartments.ID == ID
                    && companyDepartments.CompanyID == CompanyID
                    && companyDepartments.DepartmentsID.SequenceEqual(DepartmentsID)
                    && companyDepartments.IsActual == IsActual)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}