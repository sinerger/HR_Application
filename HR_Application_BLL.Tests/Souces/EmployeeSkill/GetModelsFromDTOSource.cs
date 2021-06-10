using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models.Custom;
using System.Collections;
using System.Collections.Generic;

namespace HR_Application_BLL.Tests.Souces.EmployeeSkill
{
    public class GetModelsFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new List<EmployeeSkillDTO>(){
                   new EmployeeSkillDTO()
                {
                    ID = 1,
                     EmployeeID= 1,
                     Date="01.01.2021",
                     IsActual=true,
                     UserID=1,
                     LevelSkillID=1,
                     SkillID=1
                } },
                new List<EmployeeSkillModel>(){
                   new EmployeeSkillModel()
                {
                    ID = 1,
                     EmployeeID= 1,
                     Date="01.01.2021",
                     IsActual=true,
                     UserID=1,
                     LevelSkillID=1,
                     SkillID=1
                }
                } };
            yield return new object[]
            {
              new List<EmployeeSkillDTO>(){
              new EmployeeSkillDTO()
                {
                    ID = 2,
                     EmployeeID= 2,
                     Date="02.02.2021",
                     IsActual=true,
                     UserID=2,
                     LevelSkillID=2,
                     SkillID=2
                           } },
              new List<EmployeeSkillModel>(){
              new EmployeeSkillModel()
                {
                     ID = 2,
                     EmployeeID= 2,
                     Date="02.02.2021",
                     IsActual=true,
                     UserID=2,
                     LevelSkillID=2,
                     SkillID=2
                }
                } };
        }
    }
}


