using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class CountryMapper : BaseMapper<CountryModel,CountryDTO>
    {
        public CountryMapper(IDBController dbController) : base(dbController)
        {
        }

        public override List<CountryModel> GetAllModelsFromDTO()
        {
            List<CountryDTO> countriesDTO = null;

            try
            {
                countriesDTO = DBController.CountryRepository.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }

            return _mapper.Map<List<CountryModel>>(countriesDTO);
        }

        public CountryModel GetCountryModelFromCountryDTOByID(int id)
        {
            if (id >= 0)
            {
                CountryDTO countryDTO = null;

                try
                {
                    countryDTO = DBController.CountryRepository.GetByID(id);
                }
                catch (Exception e)
                {
                    throw e;
                }

                return _mapper.Map<CountryModel>(countryDTO);
            }

            throw new ArgumentException("Invalid id");
        }

        public override CountryDTO GetDTOFromModel(CountryModel countryModel)
        {
            if (countryModel != null)
            {
                return _mapper.Map<CountryDTO>(countryModel);
            }

            throw new ArgumentNullException("Country model is null");
        }
    }
}
