using Dapper;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class AdressRepository
    {
        private string _connectionString;

        public AdressRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<AdressDTO> GetAll()
        {
            string query = "[HRAppDB].[GetAdress]";
            List<AdressDTO> result = new List<AdressDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<AdressDTO, CityDTO, CountryDTO, AdressDTO>
                        (query,
                        (adress, city, country) =>
                        {
                            adress.City = city;
                            adress.Country = country;

                            return adress;
                        }
                        )
                        .AsList<AdressDTO>();
                }
            }
            catch(Exception e)
            {
                var s = e.ToString();
                result = null;
            }

            return result;
        }
    }
}