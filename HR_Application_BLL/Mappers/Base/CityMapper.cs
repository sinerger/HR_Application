using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class CityMapper : BaseMapper
    {
        public List<CityModel> GetModelsFromDTO(List<CityDTO> citiesDTO)
        {
            if (citiesDTO != null)
            {
                return _mapper.Map<List<CityModel>>(citiesDTO);
            }

            throw new ArgumentNullException("List cities is null");
        }

        public CityModel GetModelFromDTO(CityDTO cityDTO)
        {
            if (cityDTO != null)
            {
                return _mapper.Map<CityModel>(cityDTO);
            }

            throw new ArgumentNullException("City DTO is null");
        }

        public CityDTO GetDTOFromModel(CityModel cityModel)
        {
            if (cityModel != null)
            {
                return _mapper.Map<CityDTO>(cityModel);
            }

            throw new ArgumentNullException("City model is null");
        }
    }
}
