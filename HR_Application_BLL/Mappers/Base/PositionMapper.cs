using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class PositionMapper : BaseMapper
    {
        public List<PositionModel> GetModelsFromDTO(List<PositionDTO> positionsDTO)
        {
            if (positionsDTO != null)
            {
                return _mapper.Map<List<PositionModel>>(positionsDTO);
            }

            throw new ArgumentNullException("List positions is null");
        }

        public PositionModel GetModelFromDTO(PositionDTO positionDTO)
        {
            if (positionDTO != null)
            {
                return _mapper.Map<PositionModel>(positionDTO);
            }

            throw new ArgumentNullException("Position DTO is null");
        }

        public PositionDTO GetDTOFromModel(PositionModel positionModel)
        {
            if (positionModel != null)
            {
                return _mapper.Map<PositionDTO>(positionModel);
            }

            throw new ArgumentNullException("Position model is null");
        }
    }
}
