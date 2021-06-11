using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;


namespace HR_Application_BLL.Tests.Souces.LevelSkill
{
    public class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
             {
                new LevelSkillModel()
                {
                    ID = 1,
                    Title = "Senior",
                           },
                new LevelSkillDTO()
                {
                    ID = 1,
                    Title = "Senior",
                }
             };
            yield return new object[]
            {
                new LevelSkillModel()
                {
                    ID = 2,
                   Title = "Middle",
                },
                new LevelSkillDTO()
                {
                    ID = 2,
                    Title = "Middle",
                }
            };
            yield return new object[]
            {
                new LevelSkillModel()
                {
                    ID = 3,
                    Title = "Junior",
                },
                new LevelSkillDTO()
                {
                    ID = 3,
                   Title = "Junior",
                }
            };
        }
    }
}
