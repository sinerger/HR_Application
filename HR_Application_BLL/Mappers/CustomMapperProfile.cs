using AutoMapper;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Mappers
{
    public class CustomMapperProfile : Profile
    {
        public CustomMapperProfile()
        {
            CreateMap<UserDTO, UserModel>();
            CreateMap<UserModel, UserDTO>();

            CreateMap<LocationDTO, LocationModel>();
            CreateMap<LocationModel, LocationDTO>();

            CreateMap<CityDTO, CityModel>();
            CreateMap<CityModel, CityDTO>();

            CreateMap<CountryDTO, CountryModel>();
            CreateMap<CountryModel, CountryDTO>();

            CreateMap<DepartmentDTO, DepartmentModel>();
            CreateMap<DepartmentModel, DepartmentDTO>();

            CreateMap<CompanyDTO, CompanyModel>();
            CreateMap<CompanyModel, CompanyDTO>();
        }
    }
}
