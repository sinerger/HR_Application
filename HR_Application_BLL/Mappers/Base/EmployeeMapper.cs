using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Mappers.Base
{
    public class EmployeeMapper : BaseMapper
    {
        public List<EmployeeModel> GetModelsFromDTO(List<EmployeeDTO> employeeDTO)
        {
            if (!(employeeDTO is null))
            {
                return _mapper.Map<List<EmployeeModel>>(employeeDTO);
            }

            throw new ArgumentException("List employees is null");
        }

        public EmployeeDTO GetDTOFromModel(EmployeeModel employeeModel)
        {
            if (!(employeeModel is null))
            {
                return _mapper.Map<EmployeeDTO>(employeeModel);
            }

            throw new ArgumentException("Employee model is null");
        }

        public EmployeeModel GetModelFromDTO(EmployeeDTO employeeDTO)
        {
            if (!(employeeDTO is null))
            {
                return _mapper.Map<EmployeeModel>(employeeDTO);
            }

            throw new ArgumentException("Employee DTO is null");
        }

    }
}
