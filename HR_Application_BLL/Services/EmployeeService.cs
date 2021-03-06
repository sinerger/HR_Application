using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Base;
using HR_Application_DB_Logic.Models.Custom;
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
                    var departmentProject = departmentsProjects.FirstOrDefault(depProj => depProj.ProjectsID.Contains((int)employeeProject.ProjectID));
                    var companyDepartments = companiesDepartments.FirstOrDefault(comp => comp.DepartmentsID.Contains((int)departmentProject.DepartmentID));

                    employee.GeneralInformation = generalInformations.FirstOrDefault(genInform => genInform.EmployeeID == employee.ID);
                    employee.Position = positions.FirstOrDefault(pos => pos.EmployeeID == employee.ID);
                    employee.Company = companies.FirstOrDefault(comp => comp.ID == companyDepartments.CompanyID);
                    employee.Adress = adresses.FirstOrDefault(adress => adress.ID == employeeDTO.LocationID);
                    employee.Project = projects.FirstOrDefault(project => project.ID == employeeProject.ProjectID);
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

        public int Create(Employee employee)
        {
            try
            {
                EmployeeDTO employeeDTO = _employeeMapper.GetDTOFromModel(employee);

                employee.Adress.ID = new AdressService(_dbController).Create(employee.Adress);
                
                employeeDTO.LocationID = employee.Adress.ID;
                employee.ID = _dbController.EmployeeRepository.Create(employeeDTO);

                GeneralInformationDTO generalInformationDTO = new GeneralInformationModelMapper()
                    .GetDTOFromModel(employee.GeneralInformation);
                generalInformationDTO.EmployeeID = employee.ID;

                _dbController.GeneralInformationRepository.Create(generalInformationDTO);


                EmployeePositionDTO employeePositionDTO = new EmployeePositionModelMapper()
                    .GetDTOFromModel(employee.Position);
                employeePositionDTO.EmployeeID = employee.ID;
                _dbController.EmployeePositionRepository.Create(employeePositionDTO);

                _dbController.EmployeeProjectRepository.Create(new EmployeesProjectsDTO()
                {
                    EmployeeID= employee.ID,
                    ProjectID = employee.Project.ID,
                    IsActual = true,
                });

                foreach (Competence competence in employee.Competences)
                {
                    var employeeSkill = new CompetenceMapper()
                        .GetDTOFromCompetence(competence);
                    employeeSkill.EmployeeID = employee.ID;

                    _dbController.EmployeeSkillRepository.Create(employeeSkill);
                }

                foreach (CommentModel comment in employee.Comments)
                {
                    _dbController.CommentRepository.Create(new CommentMapper()
                        .GetDTOFromModel(comment));
                }

                return employee.ID;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool Update(Employee employee)
        {
            try
            {
                EmployeeDTO employeeDTO = _employeeMapper.GetDTOFromModel(employee);
                _dbController.EmployeeRepository.Update(employeeDTO);

                GeneralInformationDTO generalInformationDTO = new GeneralInformationModelMapper()
                    .GetDTOFromModel(employee.GeneralInformation);
                _dbController.GeneralInformationRepository.Update(generalInformationDTO);

                EmployeePositionDTO employeePositionDTO = new EmployeePositionModelMapper()
                    .GetDTOFromModel(employee.Position);

                if (employeePositionDTO.ID != 0)
                {
                    _dbController.EmployeePositionRepository.Update(employeePositionDTO);
                }
                else
                {
                    _dbController.EmployeePositionRepository.Create(employeePositionDTO);
                }

                var employeeProjectDTO = _dbController.EmployeeProjectRepository.GetAll().FirstOrDefault(emplProj => emplProj.EmployeeID == employee.ID);
                employeeProjectDTO.ProjectID = employee.Project.ID;

                _dbController.EmployeeProjectRepository.Update(employeeProjectDTO);
                foreach (Competence competence in employee.Competences)
                {
                    if (competence.ID != 0)
                    {
                        _dbController.EmployeeSkillRepository.Update(new CompetenceMapper()
                            .GetDTOFromCompetence(competence));
                    }
                    else
                    {
                        _dbController.EmployeeSkillRepository.Create(new CompetenceMapper()
                            .GetDTOFromCompetence(competence));
                    }
                }

                foreach (CommentModel comment in employee.Comments)
                {
                    if (comment.ID != 0)
                    {
                        _dbController.CommentRepository.Update(new CommentMapper()
                            .GetDTOFromModel(comment));
                    }
                    else
                    {
                        _dbController.CommentRepository.Create(new CommentMapper()
                            .GetDTOFromModel(comment));
                    }
                }

                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
