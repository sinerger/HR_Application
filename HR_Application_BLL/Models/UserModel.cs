using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{FirstName} {LastName} {Company} {City}");

            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is UserModel)
            {
                var user = (UserModel)obj;

                if (user.ID == ID
                    && user.FirstName == FirstName
                    && user.LastName == LastName
                    && user.Company == Company
                    && user.Email == Email
                    && user.Password == Password
                    && user.City == City)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
