using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR_Application_BLL.Mappers
{
    public class UserMapper : BaseMapper
    {
        public List<User> GetUsersFromDTO(List<UserDTO> usersDTO)
        {
            if (usersDTO != null)
            {
                return _mapper.Map<List<User>>(usersDTO);
            }

            throw new ArgumentNullException("List users DTO is null");
        }

        public User GetUserFromDTO(UserDTO userDTO)
        {
            if (userDTO != null)
            {
                return _mapper.Map<User>(userDTO);
            }

            throw new ArgumentNullException("User DTO is null");
        }

        public UserDTO GetDTOFromUser(User user)
        {
            if (user != null)
            {
                return _mapper.Map<UserDTO>(user);
            }

            throw new ArgumentNullException("User is null");
        }
    }
}
