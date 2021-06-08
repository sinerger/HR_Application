using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Repositories;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models.Custom;

namespace HR_Application_DB_Logic
{

    public class DBController : IDBController
    {
        private string _connectionString;

        public DBController(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IRepository<AdressDTO> AdressRepository => new AdressRepository(_connectionString);
        public IRepository<CityDTO> CityRepository => new CityRepository(_connectionString);
        public CommentRepository CommentRepository => new CommentRepository(_connectionString);
        public CompanyDepartmentsRepository CompanyDepartmentsRepository => new CompanyDepartmentsRepository(_connectionString);
        public IRepository<CompanyDTO> CompanyRepository => new CompanyRepository(_connectionString);
        public IRepository<CountryDTO> CountryRepository => new CountryRepository(_connectionString);
        public DepartmentProjectsRepository DepartmentProjectsRepository => new DepartmentProjectsRepository(_connectionString);
        public IRepository<DepartmentDTO> DepartmentRepository => new DepartmentRepository(_connectionString);
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
        public IRepository<LocationDTO> LocationRepository => new LocationRepository(_connectionString);
        public PositionRepository PositionRepository => new PositionRepository(_connectionString);
        public ProjectRepository ProjectRepository => new ProjectRepository(_connectionString);
        public RequirementRepository RequirementRepository => new RequirementRepository(_connectionString);
        public SkillRepository SkillRepository => new SkillRepository(_connectionString);
        public StatusRepository StatusRepository => new StatusRepository(_connectionString);
        public IRepository<UserDTO> UserRepository => new UserRepository(_connectionString);
        public IRepository<CompanyAdressDTO> CompanyAdressRepository => new CompanyAdressRepository(_connectionString);
    }
}
