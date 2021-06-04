using HR_Application_DB_Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Interfaces
{
    public interface IDBController
    {
        AdressRepository AdressRepository { get; }
        CityRepository CityRepository { get; }
        CommentRepository CommentRepository { get; }
        CompanyDepartmentsRepository CompanyDepartmentsRepository { get; }
        CompanyRepository CompanyRepository { get; }
        CountryRepository CountryRepository { get; }
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
        LocationRepository LocationRepository { get; }
        PositionRepository PositionRepository { get; }
        ProjectRepository ProjectRepository { get; }
        RequirementRepository RequirementRepository { get; }
        SkillRepository SkillRepository { get; }
        StatusRepository StatusRepository { get; }
        UserRepository UserRepository { get; }
    }
}
