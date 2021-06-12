using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class CountryRepository : IRepository<CountryDTO>
    {
        public string ConnectionString { get; private set; }

        public CountryRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public CountryDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetCountryByID @ID";
            CountryDTO result = null;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<CountryDTO>(query, new { id });
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
            string query = "[HRAppDB].DeleteCounty @ID";
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

        public int Create(CountryDTO country)
        {
            string query = "[HRAppDB].CreateCounty @Name";
            int returnID = 0;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.QuerySingle<int>(query, new { country.Name });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }

        public bool Update(CountryDTO country)
        {
            string query = "[HRAppDB].UpdateCounty @ID, @Name";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { country.ID, country.Name });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public List<CountryDTO> GetAll()
        {
            string query = "[HRAppDB].GetCountries";
            List<CountryDTO> result = null;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<CountryDTO>(query).AsList<CountryDTO>();
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
