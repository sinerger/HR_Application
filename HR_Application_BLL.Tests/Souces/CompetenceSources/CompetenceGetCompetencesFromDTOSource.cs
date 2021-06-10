using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models.Custom;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.CompetenceSources
{
    public class CompetenceGetCompetencesFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
                 {
                new List<EmployeeSkillDTO>()
                {
                    new EmployeeSkillDTO()
                    {
                     ID = 1,
                     EmployeeID= 1,
                     Date="01.01.2021",
                     IsActual=true,
                     UserID=1,
                     LevelSkillID=1,
                     SkillID=1
                    }
                },

                new List<Competence>()
                {
                    new Competence()
                    {
                        ID = 1,
                        EmployeeID= 1,
                        Date="01.01.2021"
                    }
                    }
            };
        }
    }
}
