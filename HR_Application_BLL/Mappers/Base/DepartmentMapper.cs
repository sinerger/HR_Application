using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class DepartmentMapper : BaseMapper
    {
        public List<DepartmentModel> GetModelsFromDTO(List<DepartmentDTO> departmentsDTO)
        {
            if (departmentsDTO != null)
            {
                return _mapper.Map<List<DepartmentModel>>(departmentsDTO);
            }

            throw new ArgumentNullException("List departments is null");
        }

        public DepartmentModel GetModelFromDTO(DepartmentDTO departmentDTO)
        {
            if (departmentDTO != null)
            {
                return _mapper.Map<DepartmentModel>(departmentDTO);
            }

            throw new ArgumentNullException("Department DTO is null");
        }

        public DepartmentDTO GetDTOFromModel(DepartmentModel departmentModel)
        {
            if (departmentModel != null)
            {
                return _mapper.Map<DepartmentDTO>(departmentModel);
            }

            throw new ArgumentNullException("Department model is null");
        }
    }
}
