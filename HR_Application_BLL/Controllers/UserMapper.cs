using AutoMapper;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Controllers
{
    public class UserMapper
    {

        private MapperConfiguration _mapperConfig;
        private Mapper _mapper;
        public IDBController DBController { get; set; }

        public UserMapper(IDBController dbController)
        {
            DBController = dbController;

            _mapperConfig = new MapperConfiguration(config => config.CreateMap<UserDTO, UserModel>()
            .ForMember(dest => dest.Company, option => option
              .MapFrom(sourse => sourse.Company.Title))
            .ForMember(dest => dest.City, option => option
              .MapFrom(sourse => sourse.Adress.City.Name)));

            _mapper = new Mapper(_mapperConfig);
        }

        public List<UserModel> GetAllFromUserDTOToUserModel()
        {
            List<UserDTO> users = new List<UserDTO>();
            try
            {
                users = DBController.UserRepository.GetAll();
            }
            catch(Exception e)
            {
                throw e;
            }

            List<UserModel> userModels = _mapper.Map<List<UserModel>>(users);

            return userModels;

        }
    }
}
