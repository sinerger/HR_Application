using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HR_Application_DB_Logic.Repositories
{
    public class CompanyAdressRepository : IRepository<CompanyAdressDTO>
    {
        public string ConnectionString { get; }

        public CompanyAdressRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool Create(CompanyAdressDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CompanyAdressDTO> GetAll()
        {
            string query = "[HRAppDB].[GetCompaniesAdreses]";
            List<CompanyAdressDTO> result = null;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<CompanyAdressDTO, AdressDTO, CityDTO, CountryDTO, CompanyAdressDTO>(query,
                        (companyAdress, adress, city, country) =>
                        {
                            companyAdress.Adress = adress;
                            companyAdress.Adress.City = city;
                            companyAdress.Adress.City.CountryID = country.ID;
                            companyAdress.Adress.Country = country;

                            return companyAdress;
                        })
                        .AsList<CompanyAdressDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public CompanyAdressDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetCompanyAdressByCompanyID @ID";
            CompanyAdressDTO result = null;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<CompanyAdressDTO, AdressDTO, CityDTO, CountryDTO, CompanyAdressDTO>(query,
                        (companyAdress, adress, city, country) =>
                        {
                            companyAdress.Adress = adress;
                            companyAdress.Adress.City = city;
                            companyAdress.Adress.City.CountryID = country.ID;
                            companyAdress.Adress.Country = country;

                            return companyAdress;
                        }, new { id })
                        .AsList<CompanyAdressDTO>()[0];
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Update(CompanyAdressDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
