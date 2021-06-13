using AutoMapper;
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

            CreateMap<Adress, LocationDTO>().ForMember(dest => dest.CityID, option => option.MapFrom(source => source.City.ID))
                .ForMember(dest=>dest.ID,option=>option.MapFrom(source=>source.ID));

            CreateMap<DepartmentDTO, DepartmentModel>();
            CreateMap<DepartmentModel, DepartmentDTO>();

            CreateMap<DepartmentDTO, Department>();
            CreateMap<Department, DepartmentDTO>();

            CreateMap<CompanyDTO, CompanyModel>();
            CreateMap<CompanyModel, CompanyDTO>();

            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>().ForMember(dest=>dest.IsActual,option=>option.MapFrom(source=>true));
            CreateMap<PositionDTO, PositionModel>();
            CreateMap<PositionModel, PositionDTO>();

            CreateMap<LevelsPositionDTO, LevelsPositionModel>();
            CreateMap<LevelsPositionModel, LevelsPositionDTO>();

            CreateMap<EmployeePositionDTO, Position>();
            CreateMap<Position, EmployeePositionDTO>().ForMember(dest=>dest.PositionID,option=>option.MapFrom(source=>source.Post.ID))
                .ForMember(dest => dest.LevelPositionID, option => option.MapFrom(source => source.Level.ID));

            CreateMap<UserModel, User>();
            CreateMap<User, UserModel>().ForMember(dest=>dest.IsActual,option=>option.MapFrom(source=>true));

            CreateMap<ProjectDTO, ProjectModel>();
            CreateMap<ProjectModel, ProjectDTO>();

            CreateMap<DepartmentProjectsDTO, DepartmentProjectsModel>();
            CreateMap<DepartmentProjectsModel, DepartmentProjectsDTO>();

            CreateMap<CompanyDepartmentsDTO, CompanyDepartmentsModel>();
            CreateMap<CompanyDepartmentsModel, CompanyDepartmentsDTO>();

            CreateMap<CompanyDTO, Company>();
            CreateMap<Company, CompanyDTO>();

            CreateMap<EmployeeDTO, EmployeeModel>();
            CreateMap<EmployeeModel, EmployeeDTO>();

            CreateMap<EmployeeDTO, Employee>();
            CreateMap<Employee, EmployeeDTO>().ForMember(dest=>dest.LocationID,option=>option.MapFrom(source=>source.Adress.ID));

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

            CreateMap<CommentDTO, CommentModel>();
            CreateMap<CommentModel, CommentDTO>();

            CreateMap<GeneralInformationDTO, GeneralInformationModel>();
            CreateMap<GeneralInformationModel, GeneralInformationDTO>();
        }
    }
}