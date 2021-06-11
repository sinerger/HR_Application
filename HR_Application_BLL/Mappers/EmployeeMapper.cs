using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Mappers
{
    public class EmployeeMapper : BaseMapper
    {
        public List<Employee> GetModelsFromDTO(List<EmployeeDTO> employeeDTOs)
        {
            if (employeeDTOs != null)
            {
                return _mapper.Map<List<Employee>>(employeeDTOs);
            }

            throw new ArgumentNullException("List employees is null");
        }

        public Employee GetEmployeeFromDTO(EmployeeDTO employeeDTO)
        {
            if (employeeDTO != null)
            {
                return _mapper.Map<Employee>(employeeDTO);
            }

            throw new ArgumentNullException("Employee DTO is null");
        }

        public EmployeeDTO GetDTOFromModel(Employee employeeModel)
        {
            if (employeeModel != null)
            {
                return _mapper.Map<EmployeeDTO>(employeeModel);
            }

            throw new ArgumentNullException("Employee is null");
        }
    }
}
