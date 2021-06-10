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
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();

            CreateMap<LocationDTO, LocationModel>();
            CreateMap<LocationModel, LocationDTO>();

            CreateMap<CityDTO, CityModel>();
            CreateMap<CityModel, CityDTO>();

            CreateMap<CountryDTO, CountryModel>();
            CreateMap<CountryModel, CountryDTO>();

            CreateMap<DepartmentDTO, DepartmentModel>();
            CreateMap<DepartmentModel, DepartmentDTO>();

            CreateMap<SkillDTO, SkillModel>();
            CreateMap<SkillModel, SkillDTO>();

            CreateMap<LevelSkillDTO, LevelSkillModel>();
            CreateMap<LevelSkillModel, LevelSkillDTO>();

            CreateMap <EmployeeSkillDTO, EmployeeSkillModel>();
            CreateMap<EmployeeSkillModel, EmployeeSkillDTO>();

            CreateMap<EmployeeSkillDTO, Competence>();
            CreateMap<Competence, EmployeeSkillDTO>();

            CreateMap<Competence, EmployeeSkillDTO>().ForMember(dest=>dest.SkillID,option=>option.MapFrom(source=>source.Skill.ID))
                .ForMember(dest => dest.LevelSkillID, option => option.MapFrom(source => source.LevelSkill.ID))
                .ForMember(dest=>dest.IsActual, option=>option.MapFrom(source=>true));
            CreateMap<EmployeeSkillDTO, Competence>();
        }
    }
}
