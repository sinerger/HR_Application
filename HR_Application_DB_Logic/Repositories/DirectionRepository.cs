using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HR_Application_DB_Logic.Models;

namespace HR_Application_DB_Logic.Repositories
{
    public class DirectionRepository
    {
        private string _connectionString;

        public DirectionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DirectionDTO GetByID(int ID)
        {
            string query = "GetDirectionByID @ID";
            var result = new DirectionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<DirectionDTO>(query, new { ID });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public List<DirectionDTO> GetAll()
        {
            string query = "GetAllDirectionDTO";
            var result = new List<DirectionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<DirectionDTO>(query).AsList<DirectionDTO>();
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
