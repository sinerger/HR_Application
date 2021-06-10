using AutoMapper;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HR_Application_BLL.Mappers
{
    public class AdressMapper : BaseMapper
    {
        public List<Adress> GetModelsFromDTO(List<LocationDTO> locationsDTO, List<CityDTO> citiesDTO, List<CountryDTO> countriesDTO)
        {
            if (locationsDTO != null && citiesDTO != null && countriesDTO != null)
            {
                List<LocationModel> locations = new LocationMapper().GetModelsFromDTO(locationsDTO);
                List<CityModel> cities = new CityMapper().GetModelsFromDTO(citiesDTO);
                List<CountryModel> countries = new CountryMapper().GetModelsFromDTO(countriesDTO);
                List<Adress> adresses = _mapper.Map<List<Adress>>(locations);

                foreach (Adress adress in adresses)
                {
                    var city = cities.First(city => city.ID == adress.CityID);
                    adress.City = city;
                    adress.Country = countries.First(country => country.ID == city.CountryID);
                }

                return adresses;
            }

            throw new ArgumentNullException("Some list is null");
        }

        public Adress GetModelFromDTO(LocationDTO locationDTO, CityDTO cityDTO, CountryDTO countryDTO)
        {
            if (locationDTO != null && cityDTO != null && countryDTO != null)
            {
                LocationModel location = new LocationMapper().GetModelFromDTO(locationDTO);
                CityModel city = new CityMapper().GetModelFromDTO(cityDTO);
                CountryModel country = new CountryMapper().GetModelFromDTO(countryDTO);
                Adress adress = _mapper.Map<Adress>(location);
                adress.City = city;
                adress.Country = country;

                return adress;
            }

            throw new ArgumentNullException("Some object is null");
        }
    }
}
