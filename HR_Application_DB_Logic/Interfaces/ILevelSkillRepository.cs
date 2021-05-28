using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Interfaces
{
    public interface ILevelSkillRepository
    {
        List<LevelSkillDTO> GetLevelSkills();
        List<LevelSkillDTO> GetLevelSkillsByID(int levelSkillID);
        List<LevelSkillDTO> GetLevelSkillsByTitle(string LevelSkillsTitle);
        bool Insert(LevelSkillDTO levelSkill);
        bool Update(LevelSkillDTO levelSkill);
        bool Delete(int levelSkillId);
    }
}
