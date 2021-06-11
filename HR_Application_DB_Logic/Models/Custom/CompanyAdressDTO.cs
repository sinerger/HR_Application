using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models.Custom
{
    public class CompanyAdressDTO
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? IsActual { get; set; }
        public AdressDTO Adress { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is CompanyAdressDTO)
            {
                CompanyAdressDTO companyDTO = (CompanyAdressDTO)obj;
                if (companyDTO.ID == ID
                    && companyDTO.Title == Title
                    && companyDTO.Adress.Equals(Adress)
                    && companyDTO.Description == Description
                    && companyDTO.IsActual == IsActual)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
