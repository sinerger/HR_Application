using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces.LevelSkill
{
    public class GetModelFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new LevelSkillDTO()
                {
                    ID = 1,
                    Title = "Senior",
                },
                new LevelSkillModel()
                {
                    ID = 1,
                    Title = "Senior",
                }
            };
            yield return new object[]
            {
                new LevelSkillDTO()
                {
                    ID = 2,
                    Title = "Middle",
                },
                new LevelSkillModel()
                {
                    ID = 2,
                   Title = "Middle",
                }
            };
            yield return new object[]
            {
                new LevelSkillDTO()
                {
                    ID = 3,
                   Title = "Junior",
                },
                new LevelSkillModel()
                {
                    ID = 3,
                    Title = "Junior",
                }
            };
        }
    }
}
