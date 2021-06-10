﻿using AutoMapper;
using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using HR_Application_DB_Logic.Models.Base;

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

            CreateMap<LocationModel, Adress>();
            CreateMap<Adress, LocationModel>();

            CreateMap<DepartmentDTO, DepartmentModel>();
            CreateMap<DepartmentModel, DepartmentDTO>();

            CreateMap<DepartmentDTO, Department>();
            CreateMap<Department, DepartmentDTO>();

            CreateMap<CompanyDTO, CompanyModel>();
            CreateMap<CompanyModel, CompanyDTO>();

            CreateMap<PositionDTO, PositionModel>();
            CreateMap<PositionModel, PositionDTO>();

            CreateMap<LevelsPositionDTO, LevelsPositionModel>();
            CreateMap<LevelsPositionModel, LevelsPositionDTO>();

            CreateMap<EmployeePositionDTO, EmployeePositionModel>();
            CreateMap<EmployeePositionModel, EmployeePositionDTO>();

            CreateMap<UserModel, User>();
            CreateMap<User, UserModel>().ForMember(dest=>dest.IsActual,option=>option.MapFrom(source=>true));

            CreateMap<ProjectDTO, ProjectModel>();
            CreateMap<ProjectModel, ProjectDTO>();

            CreateMap<DepartmentProjectsDTO, DepartmentProjectsModel>();
            CreateMap<DepartmentProjectsModel, DepartmentProjectsDTO>();

            CreateMap<CompanyDepartmentsDTO, CompanyDepartmentsModel>();
            CreateMap<CompanyDepartmentsModel, CompanyDepartmentsDTO>();
        }
    }
}