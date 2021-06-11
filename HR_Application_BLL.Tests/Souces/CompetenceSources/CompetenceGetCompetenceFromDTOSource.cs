using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.CompetenceSources
{
    public class CompetenceGetCompetenceFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
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
                },

                new Competence()
                {
                        ID = 1,
                        EmployeeID= 1,
                        Date="01.01.2021"
                    }
        };
        }
    }
}
