using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Tests.Souces.Skill
{
    public class GetModelsFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                 new List<SkillDTO>()
                {
                    new SkillDTO()
                    {
                        ID = 1,
                        Title = "C#",
                        Description="C# dev"
                    },
                    new SkillDTO()
                    {
                        ID = 2,
                        Title = "Java",
                        Description="Java dev"
                    },
                    new SkillDTO()
                    {
                        ID = 3,
                        Title = "Ruby",
                        Description="Ruby dev"
                    }
                },
                new List<SkillModel>()
                {
                    new SkillModel()
                    {
                        ID = 1,
                        Title = "C#",
                        Description="C# dev"
                    },
                    new SkillModel()
                    {
                        ID = 2,
                        Title = "Java",
                        Description="Java dev"
                    },
                    new SkillModel()
                    {
                         ID = 3,
                        Title = "Ruby",
                        Description="Ruby dev"
                    }
                }
            };
        }
    }
}
