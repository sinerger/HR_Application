using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models.Base
{
    public class GeneralInformationModel
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string Sex { get; set; }
        public string Education { get; set; }
        public int FamilyStatusID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string Hobby { get; set; }
        public int AmountChildren { get; set; }

        public GeneralInformationModel Clone()
        {
            return new GeneralInformationModel()
            {
                EmployeeID = EmployeeID,
                Sex = Sex,
                Education = Education,
                FamilyStatusID = FamilyStatusID,
                Phone = Phone,
                Email = Email,
                BirthDate = BirthDate,
                Hobby = Hobby,
                AmountChildren = AmountChildren
            };
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is GeneralInformationModel)
            {
                GeneralInformationModel generalInformation = (GeneralInformationModel)obj;

                if (generalInformation.ID == ID
                    && generalInformation.EmployeeID == EmployeeID
                    && generalInformation.Sex == Sex
                    && generalInformation.Education == Education
                    && generalInformation.FamilyStatusID == FamilyStatusID
                    && generalInformation.Phone == Phone
                    && generalInformation.Email == Email
                    && generalInformation.BirthDate == BirthDate
                    && generalInformation.Hobby == Hobby
                    && generalInformation.AmountChildren == AmountChildren)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
