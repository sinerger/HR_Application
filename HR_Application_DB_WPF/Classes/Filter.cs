using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_WPF.Classes
{
    public class Filter
    {
        public List<Competence> Competences { get; set; }
        public List<CityModel> Cities { get; set; }
        public List<Department> Departments { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (Competences != null)
            {
                foreach (var competence in Competences)
                {
                    result.Append($"{competence.ToString()}, ");
                }
            }
            if (Cities != null)
            {
                foreach (var city in Cities)
                {
                    result.Append($"{city.ToString()}, ");
                }
            }
            if (Departments != null)
            {
                foreach (var department in Departments)
                {
                    result.Append($"{department.ToString()}, ");
                }
            }

            return result.ToString().Trim();
        }
    }
}
