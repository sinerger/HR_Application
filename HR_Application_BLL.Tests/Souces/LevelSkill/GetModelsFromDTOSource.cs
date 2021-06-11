using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.LevelSkill
{
    public class GetModelsFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
             {
                new List<LevelSkillDTO>()
                {
                    new LevelSkillDTO()
                    {
                        ID = 1,
                        Title = "Senior",
                    },
                    new LevelSkillDTO()
                    {
                        ID = 2,
                        Title = "Middle",
                    },
                    new LevelSkillDTO()
                    {
                        ID = 3,
                        Title = "Junior",
                    }
                },
                new List<LevelSkillModel>()
                {
                    new LevelSkillModel()
                    {
                        ID = 1,
                        Title = "Senior",
                    },
                    new LevelSkillModel()
                    {
                        ID = 2,
                        Title = "Middle",
                    },
                    new LevelSkillModel()
                    {
                         ID = 3,
                        Title = "Junior",
                    }
                }
             };
        }
    }
}
