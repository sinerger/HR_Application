using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HR_Application_BLL.Models.Base;

namespace HR_Application_BLL.Mappers
{
    class EmployeePositionMapper : BaseMapper
    {
        public List<EmployeePosition> GetUsersFromModels(List<EmployeePositionModel> employeePositionsModel, List<PositionModel> positions, List<LevelsPositionModel> levelsPositions)
        {
            if (employeePositionsModel != null && positions != null && levelsPositions != null)
            {
                var emploeePositions = _mapper.Map<List<EmployeePosition>>(employeePositionsModel);
                foreach (var emploeePosition in emploeePositions)
                {
                    var employeePositionModel = employeePositionsModel.First(emploeePositionModel => emploeePositionModel.ID == emploeePosition.ID);
                    employeePosition.PositionID = positions.First(position => position.ID == employeePositionModel.PositionID);
                    employeePosition.LevelPositionID = levelsPositions.First(levelPosition => levelPosition.ID == employeePositionModel.LevelPositionID);
                }

                return emploeePositions;
            }
            else if (employeePositionsModel == null)
            {
                throw new ArgumentNullException("List users EmployeePosition is null");
            }
            else
            {
                throw new ArgumentNullException("List positions is null");
            }
        }
    }
}