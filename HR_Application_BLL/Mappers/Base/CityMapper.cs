using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class CityMapper : BaseMapper<CityModel,CityDTO>
    {
        public CityMapper(IDBController dbController) : base(dbController)
        {
        }

        public override List<CityModel> GetAllModelsFromDTO()
        {
            List<CityDTO> citiesDTO = null;

            try
            {
                citiesDTO = DBController.CityRepository.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }

            return _mapper.Map<List<CityModel>>(citiesDTO);
        }

        public  CityModel GetModelFromDTOByID(int id)
        {
            if (id >= 0)
            {
                CityDTO cityDTO = null;

                try
                {
                    cityDTO = DBController.CityRepository.GetByID(id);
                }
                catch (Exception e)
                {
                    throw e;
                }

                return _mapper.Map<CityModel>(cityDTO);
            }

            throw new ArgumentException("Invalid id");
        }

        public override CityDTO GetDTOFromModel(CityModel cityModel)
        {
            if(cityModel != null)
            {
                return _mapper.Map<CityDTO>(cityModel);
            }

            throw new ArgumentNullException("City model is null");
        }
    }
}
