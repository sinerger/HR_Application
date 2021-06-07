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
        public IDBController DBController { get; private set; }

        public UserMapper(IDBController dbController)
        {
            DBController = dbController;
        }

        public List<UserModel> GetAllUserModelsFromUserDTO()
        {
            List<UserDTO> users = new List<UserDTO>();
            _mapper = new Mapper(GetMapperConfigurationForMapUserDTOToUserModel());

            try
            {
                users = DBController.UserRepository.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }

            List<UserModel> userModels = _mapper.Map<List<UserModel>>(users);

            return userModels;
        }

        public UserDTO GetUserDTOFromUserModel(UserModel userModel)
        {
            if (userModel != null)
            {
                _mapper = new Mapper(GetMapperConfigurationForMapUserModelToUserDTO());
                UserDTO userDTO = new UserDTO();

                try
                {
                    userDTO = _mapper.Map<UserDTO>(userModel);
                }
                catch (Exception e)
                {
                    throw e;
                }

                return userDTO;
            }

            throw new ArgumentNullException("User model is null");
        }

        private MapperConfiguration GetMapperConfigurationForMapUserModelToUserDTO()
        {
            return new MapperConfiguration(config => config.CreateMap<UserModel, UserDTO>()
            .ForMember(dest => dest.Company, option => option
             .MapFrom(sourse => new CompanyDTO() { Title = sourse.Company }))
            .ForMember(dest => dest.Adress, option => option
             .MapFrom(sourse => new AdressDTO() { City = new CityDTO() { Name = sourse.City } })));
        }

        private MapperConfiguration GetMapperConfigurationForMapUserDTOToUserModel()
        {
            return new MapperConfiguration(config => config.CreateMap<UserDTO, UserModel>()
            .ForMember(dest => dest.Company, option => option
              .MapFrom(sourse => sourse.Company.Title))
            .ForMember(dest => dest.City, option => option
              .MapFrom(sourse => sourse.Adress.City.Name)));
        }
    }
}
