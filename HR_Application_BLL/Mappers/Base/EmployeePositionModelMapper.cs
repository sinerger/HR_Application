using AutoMapper;
using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers
{
  public class EmployeePositionModelMapper : BaseMapper
    {
        public List<EmployeePositionModel> GetModelsFromDTO(List<EmployeePositionDTO> employeePositionsDTO)
        {
            if (employeePositionsDTO != null)
            {
                return _mapper.Map<List<EmployeePositionModel>>(employeePositionsDTO);
            }

            throw new ArgumentNullException("List EmploeePosition DTO is null");
        }

        public EmployeePositionModel GetModelFromDTO(EmployeePositionDTO employeePositionsDTO)
        {
            if (employeePositionsDTO != null)
            {
                return _mapper.Map<EmployeePositionModel>(employeePositionsDTO);
            }

            throw new ArgumentNullException("EmploeePosition DTO is null");
        }

        public EmployeePositionDTO GetDTOFromModel(EmployeePositionModel employeePositionModel)
        {
            if (employeePositionModel != null)
            {
                return _mapper.Map<EmployeePositionDTO>(employeePositionModel);
            }

            throw new ArgumentNullException("EmploeePosition model is null");
        }
    }
}
