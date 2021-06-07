using AutoMapper;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers
{
    public class CompanyMapper
    {
        private Mapper _mapper;
        public IDBController DBController { get; private set; }

        public CompanyMapper(IDBController dbController)
        {
            DBController = dbController;
        }

        public List<Company> GetAllCompaniesFromCompanyAdressDTO()
        {
            _mapper = new Mapper(GetMapperConfigurationForMapCompanyAdressDTOToCompany());
            List<CompanyAdressDTO> allCompanies = new List<CompanyAdressDTO>();

            try
            {
                allCompanies = DBController.CompanyAdressRepository.GetAll();
            }
            catch (Exception e)
            {

                throw e;
            }

            return _mapper.Map<List<Company>>(allCompanies);
        }

        private MapperConfiguration GetMapperConfigurationForMapCompanyAdressDTOToCompany() 
        {
            return new MapperConfiguration(config => config.CreateMap<CompanyAdressDTO, Company>()
            .ForMember(dest => dest.Adress, option => option
              .MapFrom(source => new Adress() 
              { 
                  ID = (int)source.Adress.ID, 
                  City = source.Adress.City.Name, 
                  Country = source.Adress.Country.Name 
              })));
        }
    }
}
