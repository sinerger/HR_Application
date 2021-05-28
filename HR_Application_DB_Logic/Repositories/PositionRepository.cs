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
        public string query;

        public PositionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public PositionDTO GetByTitle(PositionDTO position)
        {
            query = "GetPositionByTitle";
            PositionDTO result = new PositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<PositionDTO>(query, new { position.Title });
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
            query = "GetPositions";
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
            query = "GetPositionByID @ID";
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
            query = "CreatePosition @Title @Description";
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
            query = "CreatePosition @ID, @Title, @Description";
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
            query = "DeletePosition";
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
