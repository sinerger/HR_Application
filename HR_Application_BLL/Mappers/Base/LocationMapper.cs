using AutoMapper;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class LocationMapper : BaseMapper<LocationModel,LocationDTO>
    {
        public LocationMapper(IDBController dBController) : base(dBController)
        {
        }

        public override List<LocationModel> GetAllModelsFromDTO()
        {
            List<LocationDTO> locationsDTO = null;

            try
            {
                locationsDTO = DBController.LocationRepository.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }

            return _mapper.Map<List<LocationModel>>(locationsDTO);
        }

        public LocationModel GetLocationModelsFromLocationDTOByID(int id)
        {
            if (id >= 0)
            {
                LocationDTO locationsDTO = null;

                try
                {
                    locationsDTO = DBController.LocationRepository.GetByID(id);
                }
                catch (Exception e)
                {
                    throw e;
                }

                return _mapper.Map<LocationModel>(locationsDTO);
            }

            throw new ArgumentException("Invalid id");
        }

        public override LocationDTO GetDTOFromModel(LocationModel locationModel)
        {
            if (locationModel != null)
            {
                return _mapper.Map<LocationDTO>(locationModel);
            }

            throw new ArgumentNullException("Location model is null");
        }
    }
}
