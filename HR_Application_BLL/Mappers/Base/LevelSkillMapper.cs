using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Mappers.Base
{
    public class LevelSkillMapper : BaseMapper
    {
        public List<LevelSkillModel> GetModelsFromDTO(List<LevelSkillDTO> levelSkillDTO)
        {
            if (levelSkillDTO != null)
            {
                return _mapper.Map<List<LevelSkillModel>>(levelSkillDTO);
            }

            throw new ArgumentNullException("List levelSkill is null");
        }

        public LevelSkillModel GetModelFromDTO(LevelSkillDTO levelSkillDTO)
        {
            if (levelSkillDTO != null)
            {
                return _mapper.Map<LevelSkillModel>(levelSkillDTO);
            }

            throw new ArgumentNullException("LevelSkill is null");
        }

        public LevelSkillDTO GetDTOFromModel(LevelSkillModel levelSkillModel)
        {
            if (levelSkillModel != null)
            {
                return _mapper.Map<LevelSkillDTO>(levelSkillModel);
            }

            throw new ArgumentNullException("LevelSkill model is null");
        }
    }
}
