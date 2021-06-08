using AutoMapper;
using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers
{
    public class UserModelMapper :BaseMapper
    {
        public List<UserModel> GetModelsFromDTO(List<UserDTO> usersDTO)
        {
            if (usersDTO != null)
            {
                return _mapper.Map<List<UserModel>>(usersDTO);
            }

            throw new ArgumentNullException("List user DTO is null");
        }

        public UserModel GetModelFromDTO(UserDTO userDTO)
        {
            if (userDTO != null)
            {
                return _mapper.Map<UserModel>(userDTO);
            }

            throw new ArgumentNullException("User DTO is null");
        }

        public UserDTO GetDTOFromModel(UserModel userModel)
        {
            if (userModel != null)
            {
                return _mapper.Map<UserDTO>(userModel);
            }

            throw new ArgumentNullException("User model is null");
        }
    }
}
