using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Repositories;
using HR_Application_DB_Logic.Interfaces;

namespace HR_Application_DB_Logic
{

    public class DBController : IDBController
    {
        public DBController(string aaa)
        {
            
        }
        private string _connectionString;

        public DBController(string connection)
        {
            _connectionString = connection;
        }

        public AdressRepository AdressRepository => new AdressRepository(_connectionString);

        public CityRepository CityRepository => new CityRepository(_connectionString);

        public CommentRepository CommentRepository => new CommentRepository(_connectionString);

        public CompanyDepartmentsRepository CompanyDepartmentsRepository => new CompanyDepartmentsRepository(_connectionString);

        public CompanyRepository CompanyRepository => new CompanyRepository(_connectionString);

        public CountryRepository CountryRepository => new CountryRepository(_connectionString);

        public DepartmentProjectsRepository DepartmentProjectsRepository => new DepartmentProjectsRepository(_connectionString);

        public DepartmentRepository DepartmentRepository => new DepartmentRepository(_connectionString);

        public DirectionRepository DirectionRepository => new DirectionRepository(_connectionString);

        public EmployeePositionRepository EmployeePositionRepository => new EmployeePositionRepository(_connectionString);

        public EmployeeProjectRepository EmployeeProjectRepository => new EmployeeProjectRepository(_connectionString);

        public EmployeeRepository EmployeeRepository => new EmployeeRepository(_connectionString);

        public EmployeeSkillRepository EmployeeSkillRepository => new EmployeeSkillRepository(_connectionString);

        public EmployeeStatusRepository EmployeeStatusRepository => new EmployeeStatusRepository(_connectionString);

        public GeneralInformationFamilyStatusRepository GeneralInformationFamilyStatusRepository => new GeneralInformationFamilyStatusRepository(_connectionString);

        public GeneralInformationRepository GeneralInformationRepository => new GeneralInformationRepository(_connectionString);

        public HistoriesRepository HistoriesRepository => new HistoriesRepository(_connectionString);

        public LevelPositionRepository LevelPositionRepository => new LevelPositionRepository(_connectionString);
        public LevelSkillRepository LevelSkillRepository => new LevelSkillRepository(_connectionString);
        public LocationRepository LocationRepository => new LocationRepository(_connectionString);

        public PositionRepository PositionRepository => new PositionRepository(_connectionString);

        public ProjectRepository ProjectRepository => new ProjectRepository(_connectionString);

        public RequirementRepository RequirementRepository => new RequirementRepository(_connectionString);

        public SkillRepository SkillRepository => new SkillRepository(_connectionString);

        public StatusRepository StatusRepository => new StatusRepository(_connectionString);

        public UserRepository UserRepository => new UserRepository(_connectionString);
    }
}
