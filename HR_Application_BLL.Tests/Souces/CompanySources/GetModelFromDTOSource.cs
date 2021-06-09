using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System.Collections;

namespace HR_Application_BLL.Tests.Souces.CompanySources
{
    public class GetModelFromDTOSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                new CompanyDTO()
                {
                    ID = 1,
                    Title = "WizardsDev",
                    LocationID = 1,
                    Description = "IT company",
                    IsActual = true
                },
                new CompanyModel()
                {
                    ID = 1,
                    Title = "WizardsDev",
                    LocationID = 1,
                    Description = "IT company",
                    IsActual = true
                }
            };
            yield return new object[]
            {
                new CompanyDTO()
                {
                    ID = 2,
                    Title = "SoftServ",
                    LocationID = 2,
                    Description = "Outsource company",
                    IsActual = false
                },
                new CompanyModel()
                {
                    ID = 2,
                    Title = "SoftServ",
                    LocationID = 2,
                    Description = "Outsource company",
                    IsActual = false
                }
            };
        }
    }
}