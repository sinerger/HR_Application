using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR_Application_BLL.Mappers
{
    public class DepartmentMapper : BaseMapper
    {
        public List<Department> GetDepartmentsFromDTO(List<DepartmentDTO> departmentsDTO, List<ProjectDTO> projectsDTO,
            List<DepartmentProjectsDTO> departmentsProjectsDTO)
        {
            List<Department> departments = _mapper.Map<List<Department>>(departmentsDTO);

            foreach (Department currentDepartment in departments)
            {
                var projectsID = departmentsProjectsDTO.Select(department => department.DepartmentID)
                    .Where(id => id == currentDepartment.ID);
                var projects = projectsDTO.Select(project => project)
                    .Where(project=> projectsID.Contains(project.ID));

                currentDepartment.Projects = new List<ProjectModel>();
                currentDepartment.Projects.AddRange(new ProjectMapper().GetModelsFromDTO((List<ProjectDTO>)projects));
            }

            return departments;
        }

        public Department GetDepartmentFromDTO(DepartmentDTO departmentDTO, List<ProjectDTO> projectsDTO,
            DepartmentProjectsDTO departmentProjectsDTO)
        {
            if (departmentDTO != null && projectsDTO != null && departmentProjectsDTO != null)
            {
                Department department = _mapper.Map<Department>(departmentDTO);
                department.Projects = new List<ProjectModel>();

                var projects = projectsDTO.Select(project => project)
                    .Where(project => departmentProjectsDTO.ProjectsID.Contains((int)project.ID));

                department.Projects.AddRange(new ProjectMapper().GetModelsFromDTO((List<ProjectDTO>)projects));

                return department;
            }
            else if(departmentDTO == null)
            {
                throw new ArgumentNullException("Department DTO is null");
            }
            else if(departmentProjectsDTO == null)
            {
                throw new ArgumentNullException("Department Projects DTO is null");
            }

            throw new ArgumentNullException("List projects DTO is null");
        }

        public DepartmentDTO GetDTOFromDepartment(Department department)
        {
            if (department != null)
            {
                return _mapper.Map<DepartmentDTO>(department);
            }

            throw new ArgumentNullException("Department is null");
        }
    }
}
