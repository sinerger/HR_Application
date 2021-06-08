using AutoMapper;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers
{
    public class AdressMapper : BaseMapper<Adress,AdressDTO>
    {
        public AdressMapper(IDBController dbController) : base(dbController)
        {
        }

        public override List<Adress> GetAllModelsFromDTO()
        {
            List<LocationModel> locations = new LocationMapper(DBController).GetAllModelsFromDTO();
            List<CityModel> cities = new CityMapper(DBController).GetAllModelsFromDTO();
            List<CountryModel> countries = new CountryMapper(DBController).GetAllModelsFromDTO();
            List<Adress> adresses = new List<Adress>();

            foreach (LocationModel location in locations)
            {
                foreach (CityModel city in cities)
                {
                    if(city.ID == location.CityID)
                    {
                        foreach (CountryModel country in countries)
                        {
                            if(city.CountryID == country.ID)
                            {
                                adresses.Add(new Adress() { Location = location, City = city, Country = country });
                            }
                        }
                    }
                }
            }

            return adresses;
        }
    }
}
