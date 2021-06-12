using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR_Application_BLL.Services
{
    public class EmployeeService : IService<Employee>
    {
        private IDBController _dbController;
        private Mappers.EmployeeMapper _employeeMapper;

        public EmployeeService(IDBController dbController)
        {
            _dbController = dbController;
            _employeeMapper = new Mappers.EmployeeMapper();
        }

        public List<Employee> GetAll()
        {
            try
            {
                List<EmployeeDTO> employeesDTO = _dbController.EmployeeRepository.GetAll();
                List<GeneralInformationModel> generalInformations = new GeneralInformationModelMapper()
                    .GetModelsFromDTO(_dbController.GeneralInformationRepository.GetAll());
                List<Position> positions = new PositionService(_dbController).GetAll();
                List<Company> companies = new CompanyService(_dbController).GetAll();
                List<CompanyDepartmentsDTO> companiesDepartments = _dbController.CompanyDepartmentsRepository.GetAll();
                List<Adress> adresses = new AdressService(_dbController).GetAll();
                List<EmployeesProjectsDTO> emploeesProjects = _dbController.EmployeeProjectRepository.GetAll();
                List<ProjectModel> projects = new ProjectMapper()
                    .GetModelsFromDTO(_dbController.ProjectRepository.GetAll());
                List<DepartmentProjectsDTO> departmentsProjects = _dbController.DepartmentProjectsRepository.GetAll();
                List<Competence> competences = new CompetenceService(_dbController).GetAll();
                List<Department> departments = new DepartmentService(_dbController).GetAll();
                List<CommentModel> comments = new CommentMapper()
                    .GetModelsFromDTO(_dbController.CommentRepository.GetAll());

                List<Employee> employees = new Mappers.EmployeeMapper()
                    .GetModelsFromDTO(_dbController.EmployeeRepository.GetAll());

                foreach (Employee employee in employees)
                {
                    var employeeDTO = employeesDTO.FirstOrDefault(empl => empl.ID == employee.ID);
                    var employeeProject = emploeesProjects.FirstOrDefault(empPr => empPr.EmployeeID == employee.ID);
                    var departmentProject = departmentsProjects.FirstOrDefault(depProj => depProj.ProjectsID.Contains(employeeProject.ProjectsID[0]));
                    var companyDepartments = companiesDepartments.FirstOrDefault(comp => comp.DepartmentsID.Contains((int)departmentProject.DepartmentID));

                    employee.GeneralInformation = generalInformations.FirstOrDefault(genInform => genInform.EmployeeID == employee.ID);
                    employee.Position = positions.FirstOrDefault(pos => pos.EmployeeID == employee.ID);
                    employee.Company = companies.FirstOrDefault(comp => comp.ID == companyDepartments.CompanyID);
                    employee.Adress = adresses.FirstOrDefault(adress => adress.ID == employeeDTO.LocationID);
                    employee.Project = projects.FirstOrDefault(project => project.ID == employeeProject.ProjectsID[0]);
                    employee.Competences = new List<Competence>(competences.Select(comp => comp)
                        .Where(comp => comp.EmployeeID == employee.ID));
                    employee.Department = departments.FirstOrDefault(dep => dep.ID == departmentProject.DepartmentID);
                    employee.Comments = new List<CommentModel>(comments.Select(com => com)
                        .Where(com => com.EmployeeID == employee.ID));
                }

                return employees;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Employee GetByID(int id)
        {
            try
            {
                return GetAll().FirstOrDefault(employee => employee.ID == id);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool Create(Employee employee)
        {
            try
            {
                EmployeeDTO employeeDTO = _employeeMapper.GetDTOFromModel(employee);
                employee.ID = _dbController.EmployeeRepository.Create(employeeDTO);

                GeneralInformationDTO generalInformationDTO = new GeneralInformationModelMapper()
                    .GetDTOFromModel(employee.GeneralInformation);
                _dbController.GeneralInformationRepository.Create(generalInformationDTO);

                EmployeePositionDTO employeePositionDTO = new EmployeePositionModelMapper()
                    .GetDTOFromModel(employee.Position);
                _dbController.EmployeePositionRepository.Create(employeePositionDTO);
                //ProjectDTO projectDTO = new ProjectMapper().GetDTOFromModel(employee)
                _dbController.EmployeeProjectRepository.cr
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
