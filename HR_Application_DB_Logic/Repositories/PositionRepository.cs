using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HR_Application_DB_Logic.Models;
using Dapper;

namespace HR_Application_DB_Logic.Repositories
{
    public class PositionRepository
    {
        private string _connectionString;

        public PositionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public PositionDTO GetByTitle(string title)
        {
            string query = "GetPositionByTitle @Title";
            PositionDTO result = new PositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<PositionDTO>(query, new { title });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public List<PositionDTO> GetAll()
        {
            string query = "GetPositions";
            List<PositionDTO> result = new List<PositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<PositionDTO>(query).AsList<PositionDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public PositionDTO GetById(int id)
        {
            string query = "GetPositionByID @ID";
            PositionDTO result = new PositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<PositionDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Create(PositionDTO position)
        {
            string query = "CreatePosition @Title @Description";
            bool result = true;

            try
            {
                using(IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        position.Title,
                        position.Description
                    });
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public bool Update(PositionDTO position)
        {
            string query = "CreatePosition @ID, @Title, @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        position.ID,
                        position.Title,
                        position.Description
                    });
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public bool Delete(int id)
        {
            string query = "DeletePosition @ID";
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
                return false;
            }

            return result;
        }
    }
}
