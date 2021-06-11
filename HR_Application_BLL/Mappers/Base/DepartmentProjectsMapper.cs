using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Mappers.Base
{
    public class DepartmentProjectsMapper : BaseMapper
    {
        public List<DepartmentProjectsModel> GetModelsFromDTO(List<DepartmentProjectsDTO> departmentsProjectsModel)
        {
            if(departmentsProjectsModel != null)
            {
                return _mapper.Map<List<DepartmentProjectsModel>>(departmentsProjectsModel);
            }

            throw new ArgumentNullException("List departmnts projects is null");
        }

        public DepartmentProjectsModel GetModelFromDTO(DepartmentProjectsDTO departmentProjectsDTO)
        {
            if (departmentProjectsDTO != null)
            {
                return _mapper.Map<DepartmentProjectsModel>(departmentProjectsDTO);
            }

            throw new ArgumentNullException("Departmnts projects DTO is null");
        }

        public DepartmentProjectsDTO GetDTOFromModel(DepartmentProjectsModel departmentsProjectsModel)
        {
            if (departmentsProjectsModel != null)
            {
                return _mapper.Map<DepartmentProjectsDTO>(departmentsProjectsModel);
            }

            throw new ArgumentNullException("Departmnts projects model is null");
        }
    }
}
