using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Base.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActual { get; set; }
        public int CompanyID { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is UserModel)
            {
                UserModel user = (UserModel)obj;
                if (user.ID == ID
                    && user.FirstName == FirstName
                    && user.LastName == LastName
                    && user.Email == Email
                    && user.Password == Password
                    && user.IsActual == IsActual
                    && user.CompanyID == CompanyID)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
