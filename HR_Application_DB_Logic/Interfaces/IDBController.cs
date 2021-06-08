using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using HR_Application_DB_Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Interfaces
{
    public interface IDBController
    {
        IRepository<AdressDTO> AdressRepository { get; }
        IRepository<CityDTO> CityRepository { get; }
        IRepository<CompanyAdressDTO> CompanyAdressRepository { get; }
        CommentRepository CommentRepository { get; }
        CompanyDepartmentsRepository CompanyDepartmentsRepository { get; }
        CompanyRepository CompanyRepository { get; }
        IRepository<CountryDTO> CountryRepository { get; }
        DepartmentProjectsRepository DepartmentProjectsRepository { get; }
        DepartmentRepository DepartmentRepository { get; }
        DirectionRepository DirectionRepository { get; }
        EmployeePositionRepository EmployeePositionRepository { get; }
        EmployeeProjectRepository EmployeeProjectRepository { get; }
        EmployeeRepository EmployeeRepository { get; }
        EmployeeSkillRepository EmployeeSkillRepository { get; }
        EmployeeStatusRepository EmployeeStatusRepository { get; }
        GeneralInformationFamilyStatusRepository GeneralInformationFamilyStatusRepository { get; }
        GeneralInformationRepository GeneralInformationRepository { get; }
        HistoriesRepository HistoriesRepository { get; }
        LevelPositionRepository LevelPositionRepository { get; }
        LevelSkillRepository LevelSkillRepository { get; }
        IRepository<LocationDTO> LocationRepository { get; }
        PositionRepository PositionRepository { get; }
        ProjectRepository ProjectRepository { get; }
        RequirementRepository RequirementRepository { get; }
        SkillRepository SkillRepository { get; }
        StatusRepository StatusRepository { get; }
        IRepository<UserDTO> UserRepository { get; }
    }
}
