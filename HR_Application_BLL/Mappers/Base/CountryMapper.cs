using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class CountryMapper : BaseMapper
    {
        public List<CountryModel> GetModelsFromDTO(List<CountryDTO> countriesDTO)
        {
            if(countriesDTO != null)
            {
            return _mapper.Map<List<CountryModel>>(countriesDTO);
            }

            throw new ArgumentNullException("List countires is null");
        }

        public CountryModel GetModelFromDTO(CountryDTO countryDTO)
        {
            if (countryDTO !=null)
            {
                return _mapper.Map<CountryModel>(countryDTO);
            }

            throw new ArgumentNullException("Country is null");
        }

        public CountryDTO GetDTOFromModel(CountryModel countryModel)
        {
            if (countryModel != null)
            {
                return _mapper.Map<CountryDTO>(countryModel);
            }

            throw new ArgumentNullException("Country model is null");
        }
    }
}
