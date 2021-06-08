using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL
{
    public static class AuthorizationController
    {
        private static int _minAmountSymbolPassword = 8;
        public static UserModel CurrentUser { get; private set; }

        public static bool SignIn(string email, string password)
        {
            bool result = false;

            if (IsValidEmail(email) && IsValidPassword(password))
            {
                try
                {
                    var mapper = new UserModelMapper();
                    List<UserModel> users = mapper.GetModelsFromDTO(null);

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

        public static bool RegistrationNewUser(UserModel user)
        {
            return true;
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

        public static bool IsValidPassword(string password)
        {
            bool result = true;

            if (password.Length < _minAmountSymbolPassword)
            {
                result = false;
            }

            return result;
        }
    }
}
