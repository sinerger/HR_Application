using HR_Application_BLL.Controllers;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL
{
    public static class AuthorizationController
    {
        public static UserModel CurrentUser { get; private set; }

        public static bool SignIn(string email, string password)
        {
            bool result = false;

            if (IsValidEmail(email))
            {
                try
                {
                    var mapper = new UserMapper(new DBController(DBConfigurator.ConnectionString));
                    List<UserModel> users = mapper.GetAllFromUserDTOToUserModel();

                    foreach (var user in users)
                    {
                        if (user.Email == email && user.Password == password)
                        {
                            result = true;
                            CurrentUser = user;

                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            return result;
        }

        public static bool IsValidEmail(string email)
        {
            bool result = true;

            try
            {
                var emailAdress = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
