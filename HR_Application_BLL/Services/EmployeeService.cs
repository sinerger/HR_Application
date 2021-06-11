using HR_Application_BLL.Mappers;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Services
{
    class EmployeeService
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
                List<PositionModel> positions = new PositionMapper()
                    .GetModelsFromDTO(_dbController.PositionRepository.GetAll());
                List<EmployeePositionDTO> employeesPositions = _dbController.EmployeePositionRepository.GetAll();
                List<Company> companies = new CompanyService(_dbController).GetAll();
                List<Adress> adresses = new AdressService(_dbController).GetAll();
                List<EmployeeProjectDTO>
                List<ProjectModel> projects = new ProjectMapper()
                    .GetModelsFromDTO(_dbController.ProjectRepository.GetAll());
                List<Competence> competences = new CompetenceService(_dbController).GetAll();
                List<Department> departments = new DepartmentService(_dbController).GetAll();
                List<CommentModel> comments = new CommentMapper()
                    .GetModelsFromDTO(_dbController.CommentRepository.GetAll());

                List<Employee> employees = new Mappers.EmployeeMapper()
                    .GetModelsFromDTO(_dbController.EmployeeRepository.GetAll());

                foreach (Employee employee in employees)
                {
                    var employeePosition = employeesPositions.Find(emplPos => emplPos.EmployeeID == employee.ID);
                    var employeeDTO = employeesDTO.Find(empl => empl.ID == employee.ID);
                    employee.GeneralInformation = generalInformations.Find(genInform => genInform.EmployeeID == employee.ID);
                    employee.Position = positions.Find(pos => pos.ID == employeePosition.PositionID);
                    //employee.Company = ???
                    employee.Adress = adresses.Find(adress => adress.ID == employeeDTO.LocationID);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
