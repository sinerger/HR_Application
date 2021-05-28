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

        public bool Create(DirectionDTO direction)
        {
            string query = "CreateDirection @Title @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { direction.Title, direction.Description });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(DirectionDTO direction)
        {
            string query = "UpdateDirection @ID @Title @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { direction.ID, direction.Title, direction.Description });
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
            string query = "DeleteDirection @ID";
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
    }
}
