using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Mappers
{
    public class CompanyMapper :BaseMapper
    {
        public List<Company> GetModelsFromDTO(List<CompanyDTO> companiesDTO)
        {
            if (companiesDTO != null)
            {
                return _mapper.Map<List<Company>>(companiesDTO);
            }

            throw new ArgumentNullException("List companies is null");
        }

        public Company GetModelFromDTO(CompanyDTO companyDTO)
        {
            if (companyDTO != null)
            {
                return _mapper.Map<Company>(companyDTO);
            }

            throw new ArgumentNullException("Company DTO is null");
        }

        public CompanyDTO GetDTOFromModel(Company companyModel)
        {
            if (companyModel != null)
            {
                return _mapper.Map<CompanyDTO>(companyModel);
            }

            throw new ArgumentNullException("Company is null");
        }
    }
}
