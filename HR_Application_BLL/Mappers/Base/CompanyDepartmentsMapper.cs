using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models.Base;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class CompanyDepartmentsMapper : BaseMapper
    {
        public List<CompanyDepartmentsModel> GetModelsFromDTO(List<CompanyDepartmentsDTO> companyDepartmentsModel)
        {
            if (companyDepartmentsModel != null)
            {
                return _mapper.Map<List<CompanyDepartmentsModel>>(companyDepartmentsModel);
            }

            throw new ArgumentNullException("List Company departments is null");
        }

        public CompanyDepartmentsModel GetModelFromDTO(CompanyDepartmentsDTO companyDepartmentsDTO)
        {
            if (companyDepartmentsDTO != null)
            {
                return _mapper.Map<CompanyDepartmentsModel>(companyDepartmentsDTO);
            }

            throw new ArgumentNullException("Company departments DTO is null");
        }

        public CompanyDepartmentsDTO GetDTOFromModel(CompanyDepartmentsModel companyDepartmentsModel)
        {
            if (companyDepartmentsModel != null)
            {
                return _mapper.Map<CompanyDepartmentsDTO>(companyDepartmentsModel);
            }

            throw new ArgumentNullException("Company departments model is null");
        }
    }
}