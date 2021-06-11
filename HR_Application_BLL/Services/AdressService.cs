using HR_Application_BLL.Mappers;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Services
{
    public class AdressService : IService<Adress>
    {
        private IDBController _dbController;
        private AdressMapper _adressMapper;

        public AdressService(IDBController dbController)
        {
            _dbController = dbController;
            _adressMapper = new AdressMapper();
        }

        public List<Adress> GetAll()
        {
            try
            {
                List<LocationDTO> locationsDTO = _dbController.LocationRepository.GetAll();
                List<CityDTO> citiesDTO = _dbController.CityRepository.GetAll();
                List<CountryDTO> countriesDTO = _dbController.CountryRepository.GetAll();

                return _adressMapper.GetModelsFromDTO(locationsDTO, citiesDTO, countriesDTO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Adress GetByID(int id)
        {
            if (id >= 0)
            {
                try
                {
                    LocationDTO locationDTO = _dbController.LocationRepository.GetByID(id);
                    CityDTO cityDTO = _dbController.CityRepository.GetByID((int)locationDTO.CityID);
                    CountryDTO countryDTO = _dbController.CountryRepository.GetByID((int)cityDTO.CountryID);

                    return _adressMapper.GetModelFromDTO(locationDTO, cityDTO, countryDTO);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }

            throw new ArgumentException("Invalid id");
        }
    }
}
