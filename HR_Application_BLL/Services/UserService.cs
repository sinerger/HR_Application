using HR_Application_BLL.Mappers;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Base;
using HR_Application_DB_Logic.Models.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Services
{
    public class UserService
    {
        private IDBController _dbController;
        private UserMapper _userMapper;

        public UserService(IDBController dbController)
        {
            _dbController = dbController;
            _userMapper = new UserMapper();
        }

        public List<User> GetUsers()
        {
            try
            {
                List<UserDTO> usersDTO = _dbController.UserRepository.GetAll();
                List<Company> companies = new CompanyService(_dbController).GetAll();
                List<CompanyDepartmentsDTO> companysDepartmentsDTO = _dbController.CompanyDepartmentsRepository.GetAll();

                List<User> users = _userMapper.GetUsersFromDTO(usersDTO);
                foreach (User user in users)
                {
                    user.Company = companies.Find(comp => comp.ID == usersDTO.Find(userDTO => userDTO.ID == user.ID).ID);
                }

                return users;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public User GetByID(int id)
        {
            //try
            //{
            //    UserDTO userDTO = _dbController.UserRepository.GetByID(id);
            //    User user = _userMapper.GetUserFromDTO(userDTO);
            //    user.Company = new CompanyService().GetByID(userDTO.CompanyID);

            //}
            //catch (Exception e)
            //{

            //    throw e;
            //}

            return null;
        }
    }
}
