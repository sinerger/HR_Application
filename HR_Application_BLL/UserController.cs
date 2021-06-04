using HR_Application_BLL.Controllers;
using HR_Application_DB_Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL
{
    public class UserController
    {
        public bool Autorization(string email,string password)
        {
            var a = new UserMapper(new DBController(DBConfigurator.ConnectionString));
            var users = a.GetAllFromUserDTOToUserModel();
            bool result = false;

            foreach (var user in users)
            {
                if(user.Email == email&& user.Password == password)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
