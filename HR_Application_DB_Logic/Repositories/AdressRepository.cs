using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;

namespace HR_Application_DB_Logic.Repositories
{
    public class AdressRepository : IRepository<AdressDTO>
    {
        public string ConnectionString { get; }
        public AdressRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool Create(AdressDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AdressDTO> GetAll()
        {
            string query = "[HRAppDB].GetAdress";
            List<AdressDTO> result = new List<AdressDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<AdressDTO, CityDTO, CountryDTO, AdressDTO>
                        (query,
                        (adress, city, country) =>
                        {
                            adress.City = city;
                            adress.Country = country;

                            return adress;
                        })
                        .AsList<AdressDTO>();
                }
            }
            catch (Exception e)
            {
                var s = e.ToString();
                result = null;
            }

            return result;
        }

        public AdressDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetAdressByID @ID";
            AdressDTO result = new AdressDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    var temp = dbConnection.Query<AdressDTO, CityDTO, CountryDTO, AdressDTO>
                        (query,
                        (adress, city, country) =>
                        {
                            adress.City = city;
                            adress.Country = country;

                            return adress;
                        }, new { id })
                        .AsList<AdressDTO>();

                    if (temp.Count > 0)
                    {
                        result = temp[0];
                    }
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Update(AdressDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}