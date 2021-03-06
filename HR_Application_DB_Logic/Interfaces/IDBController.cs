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
        IRepository<CommentDTO> CommentRepository { get; }
        IRepository<CompanyDepartmentsDTO> CompanyDepartmentsRepository { get; }
        IRepository<CompanyDTO> CompanyRepository { get; }
        IRepository<CountryDTO> CountryRepository { get; }
        IRepository<DepartmentProjectsDTO> DepartmentProjectsRepository { get; }
        IRepository<DepartmentDTO> DepartmentRepository { get; }
        DirectionRepository DirectionRepository { get; }
        IRepository<EmployeePositionDTO> EmployeePositionRepository { get; }
        EmployeeProjectRepository EmployeeProjectRepository { get; }
        EmployeeRepository EmployeeRepository { get; }
        IRepository<EmployeeSkillDTO> EmployeeSkillRepository { get; }
        EmployeeStatusRepository EmployeeStatusRepository { get; }
        GeneralInformationFamilyStatusRepository GeneralInformationFamilyStatusRepository { get; }
        GeneralInformationRepository GeneralInformationRepository { get; }
        HistoriesRepository HistoriesRepository { get; }
        LevelsPositionRepository LevelPositionRepository { get; }
        IRepository <LevelSkillDTO> LevelSkillRepository { get; }
        IRepository<LocationDTO> LocationRepository { get; }
        PositionRepository PositionRepository { get; }
        IRepository<ProjectDTO> ProjectRepository { get; }
        RequirementRepository RequirementRepository { get; }
        IRepository <SkillDTO> SkillRepository { get; }
        StatusRepository StatusRepository { get; }
        IRepository<UserDTO> UserRepository { get; }
    }
}