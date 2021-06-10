using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class CompanyMapper : BaseMapper
    {
        public List<CompanyModel> GetModelsFromDTO(List<CompanyDTO> companiesDTO)
        {
            if (companiesDTO != null)
            {
                return _mapper.Map<List<CompanyModel>>(companiesDTO);
            }

            throw new ArgumentNullException("List companies is null");
        }

        public CompanyModel GetModelFromDTO(CompanyDTO companyDTO)
        {
            if (companyDTO != null)
            {
                return _mapper.Map<CompanyModel>(companyDTO);
            }

            throw new ArgumentNullException("Company DTO is null");
        }

        public CompanyDTO GetDTOFromModel(CompanyModel companyModel)
        {
            if (companyModel != null)
            {
                return _mapper.Map<CompanyDTO>(companyModel);
            }

            throw new ArgumentNullException("Company model is null");
        }
    }
}