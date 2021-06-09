using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR_Application_BLL.Mappers
{
    public class UserMapper : BaseMapper
    {
        public List<User> GetUsersFromModels(List<UserModel> usersModel, List<Company> companies)
        {
            if (usersModel != null && companies != null)
            {
                var users = _mapper.Map<List<User>>(usersModel);
                foreach (var user in users)
                {
                    var userModel = usersModel.First(userModel => userModel.ID == user.ID);
                    user.Company = companies.First(company => company.ID == userModel.CompanyID);
                }

                return users;
            }
            else if (usersModel == null)
            {
                throw new ArgumentNullException("List users model is null");
            }
            else
            {
                throw new ArgumentNullException("List companies is null");
            }
        }

        public UserModel GetModelFromUser()
        {
            return null;
        }
    }
}
