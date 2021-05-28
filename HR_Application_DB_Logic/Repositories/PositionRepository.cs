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

        public PositionDTO GetByTitle(string positionTitle)
        {
            string query = "GetPositionByTitle";
            PositionDTO result = new PositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<PositionDTO>(query, new { Title = positionTitle });
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
                    result = dbConnection.Query<PositionDTO>(query, commandType: CommandType.StoredProcedure).AsList<PositionDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public PositionDTO GetById(int positionId)
        {
            string query = "GetPositionByID @ID";
            PositionDTO result = new PositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<PositionDTO>(query, new { ID = positionId });

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
