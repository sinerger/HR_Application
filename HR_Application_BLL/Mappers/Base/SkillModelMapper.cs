using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Mappers.Base
{
    public class SkillModelMapper: BaseMapper
    {
         public List<SkillModel> GetModelsFromDTO(List<SkillDTO> skillDTO)
        {
            if (skillDTO != null)
            {
                return _mapper.Map<List<SkillModel>>(skillDTO);
            }

            throw new ArgumentNullException("List skill is null");
        }

        public SkillModel GetModelFromDTO(SkillDTO skillDTO)
        {
            if (skillDTO != null)
            {
                return _mapper.Map<SkillModel>(skillDTO);
            }

            throw new ArgumentNullException("Skill is null");
        }

        public SkillDTO GetDTOFromModel(SkillModel skillModel)
        {
            if (skillModel != null)
            {
                return _mapper.Map<SkillDTO>(skillModel);
            }

            throw new ArgumentNullException("Skill model is null");
        }
    }
}
