using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Services;
using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic;

namespace HR_Application_BLL
{
    public static class AuthorizationController
    {
        private static int _minAmountSymbolPassword = 8;
        public static User CurrentUser { get; private set; }

        public static bool SignIn(string email, string password)
        {
            bool result = false;

            if (IsValidEmail(email) && IsValidPassword(password))
            {
                try
                {
                    List<User> users = new UserService(new DBController(DBConfigurator.ConnectionString)).GetAll();

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

        public static bool RegistrationNewUser(User user)
        {
            try
            {
                return new UserService(new DBController(DBConfigurator.ConnectionString)).Create(user);
            }
            catch (Exception e)
            {
                throw e ;
            }
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
