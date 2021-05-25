using HR_Application_DB_Logic.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Tests.Sousces
{
    public class GeneralInformationSousec : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[]
            {
                100,
                new List<GeneralInformationDTO>(){
                    new GeneralInformationDTO()
                }
            };
        }
    }
}
