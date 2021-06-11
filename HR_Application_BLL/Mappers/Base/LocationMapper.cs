using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class LocationMapper : BaseMapper
    {
        public List<LocationModel> GetModelsFromDTO(List<LocationDTO> locationsDTO)
        {
            if (locationsDTO != null)
            {
                return _mapper.Map<List<LocationModel>>(locationsDTO);
            }

            throw new ArgumentNullException("List locations is null");
        }

        public LocationModel GetModelFromDTO(LocationDTO locationDTO)
        {
            if (locationDTO !=null)
            {
                return _mapper.Map<LocationModel>(locationDTO);
            }

            throw new ArgumentNullException("Location DTO is null");
        }

        public LocationDTO GetDTOFromModel(LocationModel locationModel)
        {
            if (locationModel != null)
            {
                return _mapper.Map<LocationDTO>(locationModel);
            }

            throw new ArgumentNullException("Location model is null");
        }
    }
}
