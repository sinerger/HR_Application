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
        public List<Department> GetDepartmentsFromDTO(List<DepartmentDTO> departmentsDTO)
        {
            if (departmentsDTO != null)
            {
                return _mapper.Map<List<Department>>(departmentsDTO);
            }

            throw new ArgumentNullException("Department DTO is null");
        }

        public Department GetDepartmentFromDTO(DepartmentDTO departmentDTO)
        {
            if (departmentDTO != null )
            {
                return _mapper.Map<Department>(departmentDTO);
            }

            throw new ArgumentNullException("Department DTO is null");
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
