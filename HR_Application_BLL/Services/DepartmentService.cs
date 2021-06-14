using HR_Application_BLL.Mappers;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Base;
using HR_Application_DB_Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR_Application_BLL.Services
{
    public class DepartmentService : IService<Department>
    {
        private IDBController _dbController;
        private DepartmentMapper _departmentMapper;

        public DepartmentService(IDBController dbController)
        {
            _dbController = dbController;
            _departmentMapper = new DepartmentMapper();
        }

        public List<Department> GetAll()
        {
            try
            {
                List<DepartmentDTO> departmentsDTO = _dbController.DepartmentRepository.GetAll();
                List<DepartmentProjectsDTO> departmentsProjectsDTO = _dbController.DepartmentProjectsRepository.GetAll();
                List<ProjectDTO> projectsDTO = _dbController.ProjectRepository.GetAll();

                List<Department> departments = _departmentMapper.GetDepartmentsFromDTO(departmentsDTO);

                foreach (Department currentDepartment in departments)
                {
                    var projectsID = departmentsProjectsDTO.Select(department => department.DepartmentID)
                        .Where(id => id == currentDepartment.ID);
                    List<ProjectDTO> projects = new List<ProjectDTO>(projectsDTO.Select(project => project)
                        .Where(project => projectsID.Contains(project.ID)));

                    currentDepartment.Projects = new List<ProjectModel>(new ProjectMapper().GetModelsFromDTO(projects));
                }

                return departments;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Department GetByID(int id)
        {
            try
            {
                DepartmentDTO departmentDTO = _dbController.DepartmentRepository.GetByID(id);
                DepartmentProjectsDTO departmentProjectsDTO = _dbController.DepartmentProjectsRepository.GetByID(id);
                List<ProjectDTO> projectsDTO = _dbController.ProjectRepository.GetAll();

                Department department = _departmentMapper.GetDepartmentFromDTO(departmentDTO);
                if (departmentProjectsDTO != null)
                {
                    List<ProjectDTO> targetProjectDTO = new List<ProjectDTO>(projectsDTO.Select(project => project)
                            .Where(project => departmentProjectsDTO.ProjectsID.Contains((int)project.ID)));
                    department.Projects = new List<ProjectModel>(new ProjectMapper().GetModelsFromDTO(targetProjectDTO));
                }
                department.Projects = new List<ProjectModel>();

                return department;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Create(Department department)
        {
            try
            {
                DepartmentDTO departmentDTO = _departmentMapper.GetDTOFromDepartment(department);
                department.ID = _dbController.DepartmentRepository.Create(departmentDTO);

                foreach (ProjectModel project in department.Projects)
                {
                    ProjectDTO projectDTO = new ProjectMapper().GetDTOFromModel(project);
                    project.ID = _dbController.ProjectRepository.Create(projectDTO);
                }

                DepartmentProjectsDTO departmentProjectsDTO = new DepartmentProjectsDTO()
                {
                    DepartmentID = department.ID,
                    ProjectsID = new List<int>(department.Projects.Select(project=>project.ID)),
                    IsActual = true
                };

                var depProjRepository = (DepartmentProjectsRepository)_dbController.DepartmentProjectsRepository;
                depProjRepository.CreateList(departmentProjectsDTO);

                return department.ID;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
