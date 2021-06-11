using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Interfaces;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class CityRepository : IRepository<CityDTO>
    {
        public string ConnectionString { get; private set; }

        public CityRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<CityDTO> GetAll()
        {
            string query = "[HRAppDB].GetCities";
            List<CityDTO> result = new List<CityDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<CityDTO>(query).AsList<CityDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Create(CityDTO city)
        {
            string query = "[HRAppDB].CreateCity @Name, @CountryID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { city.Name, city.CountryID });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Update(CityDTO city)
        {
            string query = "[HRAppDB].UpdateCity @ID, @Name, @CountryID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { city.ID, city.Name, city.CountryID });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Delete(int id)
        {
            string query = "[HRAppDB].DeleteCity @ID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public CityDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetCityByID @ID";
            CityDTO result = new CityDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<CityDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public CityDTO GetByName(string name)
        {
            string query = "[HRAppDB].GetCityByName @Name";
            CityDTO result = new CityDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<CityDTO>(query, new { name });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}
