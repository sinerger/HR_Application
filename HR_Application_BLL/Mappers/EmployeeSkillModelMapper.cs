using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models.Custom;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers
{
    public class EmployeeSkillModelMapper : BaseMapper
    {
        public List<EmployeeSkillModel> GetModelsFromDTO(List<EmployeeSkillDTO> employeeSkillDTO)
        {
            if (employeeSkillDTO != null)
            {
                return _mapper.Map<List<EmployeeSkillModel>>(employeeSkillDTO);
            }

            throw new ArgumentNullException("List employeeSkill is null");
        }

        public EmployeeSkillModel GetModelFromDTO(EmployeeSkillDTO employeeSkillDTO)
        {
            if (employeeSkillDTO != null)
            {
                return _mapper.Map<EmployeeSkillModel>(employeeSkillDTO);
            }

            throw new ArgumentNullException("EmployeeSkill is null");
        }

        public EmployeeSkillDTO GetDTOFromModel(EmployeeSkillModel employeeSkillModel)
        {
            if (employeeSkillModel != null)
            {
                return _mapper.Map<EmployeeSkillDTO>(employeeSkillModel);
            }

            throw new ArgumentNullException("EmployeeSkill model is null");
        }
    }
}

