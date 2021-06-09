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

            foreach (Department department in departments)
            {
                var projectsID = departmentsProjectsDTO.Select(dp => dp.DepartmentID)
                    .Where(id => id == department.ID);
                var projects = projectsDTO.Select(pr => pr)
                    .Where(pr=> projectsID.Contains(pr.ID));

                department.Projects = new List<ProjectModel>();
                department.Projects.AddRange(_mapper.Map<List<ProjectModel>>(projects));
            }

            return departments;
        }
    }
}
