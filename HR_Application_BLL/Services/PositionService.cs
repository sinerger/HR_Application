using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR_Application_BLL.Services
{
    public class PositionService : IService<Position>
    {
        private IDBController _dbController;
        private EmployeePositionModelMapper _positionMapper;

        public PositionService(IDBController dbController)
        {
            _dbController = dbController;
            _positionMapper = new EmployeePositionModelMapper();
        }

        public List<Position> GetAll()
        {
            try
            {
                List<EmployeePositionDTO> employeesPositionsDTO = _dbController.EmployeePositionRepository.GetAll();

                List<PositionModel> positionModels = new PositionMapper()
                    .GetModelsFromDTO(_dbController.PositionRepository.GetAll());
                List<LevelsPositionModel> levelsPositions = new LevelsPositionMapper()
                    .GetModelsFromDTO(_dbController.LevelPositionRepository.GetAll());

                List<Position> positions = _positionMapper.GetModelsFromDTO(employeesPositionsDTO);

                foreach (Position position in positions)
                {
                    var employePosition = employeesPositionsDTO.FirstOrDefault(emplPos => emplPos.ID == position.ID);
                    position.Post = positionModels.FirstOrDefault(pos => pos.ID == employePosition.PositionID);
                    position.Level = levelsPositions.FirstOrDefault(level => level.ID == employePosition.LevelPositionID);
                }

                return positions;

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Position GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
