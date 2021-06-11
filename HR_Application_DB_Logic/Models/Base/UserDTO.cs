namespace HR_Application_DB_Logic.Models
{
    public class UserDTO
    {
        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsActual { get; set; }
        public int? CompanyID { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is UserDTO)
            {
                UserDTO userDTO = (UserDTO)obj;
                if (userDTO.ID == ID
                    && userDTO.FirstName == FirstName
                    && userDTO.LastName == LastName
                    && userDTO.Email == Email
                    && userDTO.Password == Password
                    && userDTO.IsActual == IsActual
                    && userDTO.CompanyID == CompanyID)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
