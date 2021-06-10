using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Base;
using HR_Application_DB_Logic.Models.Custom;
using HR_Application_DB_Logic.Repositories;

namespace HR_Application_DB_Logic.Interfaces
{
    public interface IDBController
    {
        IRepository<AdressDTO> AdressRepository { get; }
        IRepository<CityDTO> CityRepository { get; }
        IRepository<CompanyAdressDTO> CompanyAdressRepository { get; }
        CommentRepository CommentRepository { get; }
        IRepository<CompanyDepartmentsDTO> CompanyDepartmentsRepository { get; }
        IRepository<CompanyDTO> CompanyRepository { get; }
        IRepository<CountryDTO> CountryRepository { get; }
        IRepository<DepartmentProjectsDTO> DepartmentProjectsRepository { get; }
        IRepository<DepartmentDTO> DepartmentRepository { get; }
        DirectionRepository DirectionRepository { get; }
        EmployeePositionRepository EmployeePositionRepository { get; }
        EmployeeProjectRepository EmployeeProjectRepository { get; }
        EmployeeRepository EmployeeRepository { get; }
        EmployeeSkillRepository EmployeeSkillRepository { get; }
        EmployeeStatusRepository EmployeeStatusRepository { get; }
        GeneralInformationFamilyStatusRepository GeneralInformationFamilyStatusRepository { get; }
        GeneralInformationRepository GeneralInformationRepository { get; }
        HistoriesRepository HistoriesRepository { get; }
        LevelsPositionRepository LevelPositionRepository { get; }
        LevelSkillRepository LevelSkillRepository { get; }
        IRepository<LocationDTO> LocationRepository { get; }
        PositionRepository PositionRepository { get; }
        IRepository<ProjectDTO> ProjectRepository { get; }
        RequirementRepository RequirementRepository { get; }
        SkillRepository SkillRepository { get; }
        StatusRepository StatusRepository { get; }
        IRepository<UserDTO> UserRepository { get; }
    }
}