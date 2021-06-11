using HR_Application_DB_Logic.Models;
using System.Collections;


namespace HR_Application_BLL.Tests.Souces.GeneralInformationModel
{
    public class GetDTOFromModelSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new  Models.Base.GeneralInformationModel()
                {
                  ID=1,
                  EmployeeID=1,
                  Sex= "male",
                  Education="Vishee",
                  FamilyStatusID=1,
                  Phone="0970935399",
                  Email="avakyanms@gmail.com",
                  BirthDate="02.09.1989",
                  Hobby="Music",
                  AmountChildren=1
    },
                new GeneralInformationDTO()
                {
                   ID=1,
                   EmployeeID=1,
                   Sex= "male",
                   Education="Vishee",
                   FamilyStatusID=1,
                   Phone="0970935399",
                   Email="avakyanms@gmail.com",
                   BirthDate="02.09.1989",
                   Hobby="Music",
                   AmountChildren=1
                }
            };
            yield return new object[]
            {
            new Models.Base.GeneralInformationModel()
            {
                ID = 2,
                EmployeeID = 2,
                Sex = "male",
                Education = "Vishee",
                FamilyStatusID = 2,
                Phone = "0970935399",
                Email = "avakyanms@gmail.com",
                BirthDate = "02.09.1989",
                Hobby = "Music",
                AmountChildren = 2
            },
                new GeneralInformationDTO()
                {
                ID = 2,
                EmployeeID = 2,
                Sex = "male",
                Education = "Vishee",
                FamilyStatusID = 2,
                Phone = "0970935399",
                Email = "avakyanms@gmail.com",
                BirthDate = "02.09.1989",
                Hobby = "Music",
                AmountChildren = 2
                }
                };
        }
    }
}
