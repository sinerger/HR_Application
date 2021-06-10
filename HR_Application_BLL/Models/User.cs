using HR_Application_BLL.Base.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Company Company { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} Company: {Company}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is User)
            {
                User user = (User)obj;

                if (user.ID == ID
                    && user.FirstName == FirstName
                    && user.LastName == LastName
                    && user.Email == Email
                    && user.Password == Password
                    && user.Company == Company)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
