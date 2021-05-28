using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HR_Application_DB_Logic.Models;
using Dapper;

namespace HR_Application_DB_Logic.Repositories
{
    public class StatusRepository
    {
        private string _connectionString;

        public StatusRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<StatusDTO> GetAll()
        {
            string query = "GetStatuses";
            List<StatusDTO> result = new List<StatusDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<StatusDTO>(query).AsList<StatusDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Create(StatusDTO status)
        {
            string query = "CreateStatus @Name";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { status.Name });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(StatusDTO status)
        {
            string query = "UpdateStatus @ID @Name";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { status.ID, status.Name });
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
            string query = "DeleteStatus @ID";
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

        public StatusDTO GetByID(int id)
        {
            string query = "GetStatusByID @ID";
            StatusDTO result = new StatusDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<StatusDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public StatusDTO GetByName(string name)
        {
            string query = "GetStatusByName @Name";
            StatusDTO result = new StatusDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<StatusDTO>(query, new { name });
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
