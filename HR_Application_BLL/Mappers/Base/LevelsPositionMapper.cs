using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class LevelsPositionMapper : BaseMapper
    {
        public List<LevelsPositionModel> GetModelsFromDTO(List<LevelsPositionDTO> levelsPositionsDTO)
        {
            if (levelsPositionsDTO != null)
            {
                return _mapper.Map<List<LevelsPositionModel>>(levelsPositionsDTO);
            }

            throw new ArgumentNullException("List levelsPositions is null");
        }

        public LevelsPositionModel GetModelFromDTO(LevelsPositionDTO levelsPositionDTO)
        {
            if (levelsPositionDTO != null)
            {
                return _mapper.Map<LevelsPositionModel>(levelsPositionDTO);
            }

            throw new ArgumentNullException("levelsPosition DTO is null");
        }

        public LevelsPositionDTO GetDTOFromModel(LevelsPositionModel levelsPositionModel)
        {
            if (levelsPositionModel != null)
            {
                return _mapper.Map<LevelsPositionDTO>(levelsPositionModel);
            }

            throw new ArgumentNullException("levelsPosition model is null");
        }
    }
}
