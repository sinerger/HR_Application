using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class ProjectMapper : BaseMapper
    {
        public List<ProjectModel> GetModelsFromDTO(List<ProjectDTO> projectsDTO)
        {
            if (projectsDTO != null)
            {
                return _mapper.Map<List<ProjectModel>>(projectsDTO);
            }

            throw new ArgumentNullException("List projects is null");
        }

        public ProjectModel GetModelFromDTO(ProjectDTO projectDTO)
        {
            if (projectDTO != null)
            {
                return _mapper.Map<ProjectModel>(projectDTO);
            }

            throw new ArgumentNullException("Project DTO is null");
        }

        public ProjectDTO GetDTOFromModel(ProjectModel projectModel)
        {
            if (projectModel != null)
            {
                return _mapper.Map<ProjectDTO>(projectModel);
            }

            throw new ArgumentNullException("Project model is null");
        }
    }
}