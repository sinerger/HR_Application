using AutoMapper;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers
{
    public class AdressMapper
    {
        private Mapper _mapper;
        public IDBController DBController { get; private set; }

        public AdressMapper(IDBController dbController)
        {
            DBController = dbController;
        }

        public List<Adress> GetAllAdressesFromAdressDTO()
        {
            _mapper = new Mapper(GetMapperConfigurationForMapAdressDTOToAdress());
            List<AdressDTO> allAdresses = new List<AdressDTO>();

            try
            {
                allAdresses = DBController.AdressRepository.GetAll();
            }
            catch (Exception e )
            {

                throw e;
            }

            return _mapper.Map<List<Adress>>(allAdresses);
        }

        private MapperConfiguration GetMapperConfigurationForMapAdressDTOToAdress()
        {
            return new MapperConfiguration(config => config.CreateMap<AdressDTO, Adress>()
            .ForMember(dest => dest.City, option => option
               .MapFrom(source => source.City.Name))
            .ForMember(dest => dest.Country, option => option
               .MapFrom(source => source.Country.Name)));
        }
    }
}
