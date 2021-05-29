using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class CityRepository
    {
        private string _connectionString;


        public CityRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<CityDTO> GetAll()
        {
            string query = "GetCities";
            List<CityDTO> result = new List<CityDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<CityDTO>(query).AsList<CityDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Create(CityDTO city)
        {
            string query = "CreateCity @Name @CountryID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { city.Name, city.CountryID });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(CityDTO city)
        {
            string query = "UpdateCity @ID @Name @CountryID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { city.Id, city.Name, city.CountryID });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Delete(int id)
        {
            string query = "DeleteCity @ID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { id });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public CityDTO GetByID(int id)
        {
            string query = "GetCityByID @ID";
            CityDTO result = new CityDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<CityDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public CityDTO GetByName(string name)
        {
            string query = "GetCityByName @Name";
            CityDTO result = new CityDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<CityDTO>(query, new { name });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }
    }
}
