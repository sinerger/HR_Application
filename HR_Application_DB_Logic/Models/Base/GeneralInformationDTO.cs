namespace HR_Application_DB_Logic.Models
{
    public class GeneralInformationDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public string Sex { get; set; }
        public string Education { get; set; }
        public int? FamilyStatusID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string Hobby { get; set; }
        public int? AmountChildren { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is GeneralInformationDTO)
            {
                GeneralInformationDTO generalInformationDTO = (GeneralInformationDTO)obj;

                if (generalInformationDTO.ID == ID
                    && generalInformationDTO.EmployeeID == EmployeeID
                    && generalInformationDTO.Sex == Sex
                    && generalInformationDTO.Education == Education
                    && generalInformationDTO.FamilyStatusID == FamilyStatusID
                    && generalInformationDTO.Phone == Phone
                    && generalInformationDTO.Email == Email
                    && generalInformationDTO.BirthDate == BirthDate
                    && generalInformationDTO.Hobby == Hobby
                    && generalInformationDTO.AmountChildren == AmountChildren)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
