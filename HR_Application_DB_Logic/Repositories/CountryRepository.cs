using Dapper;
using HR_Application_DB_Logic.Models;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class CountryRepository
    {

        private string _connectionString;

        public CountryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public CountryDTO GetByID(int id)
        {
            string query = "GetCountryByID";
            CountryDTO result = new CountryDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<CountryDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public CountryDTO GetByName(string Name)
        {
            string query = "GetCountryByName";
            CountryDTO result = new CountryDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<CountryDTO>(query, new { Name });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Delete(int id)
        {
            string query = "DeleteCounty @ID";
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

        public bool Create(CountryDTO country)
        {
            string query = "CreateCounty @Name";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { country.Name });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(CountryDTO country)
        {
            string query = "UpdateCounty @ID @Name";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new 
                    { 
                        country.ID,
                        country.Name 
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
