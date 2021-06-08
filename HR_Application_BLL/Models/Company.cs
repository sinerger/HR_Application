using HR_Application_BLL.Models.Base;
using System.Collections.Generic;

namespace HR_Application_BLL.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Desctiption { get; set; }
        public AdressModel Adress { get; set; }
        public List<DepartmentModel> Departments { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Company)
            {
                Company company = (Company)obj;

                if (company.ID == ID && company.Title == Title && company.Desctiption == Desctiption && company.Adress.Equals(Adress))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
