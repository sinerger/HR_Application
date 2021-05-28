using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;

namespace HR_Application_DB_Logic.Repositories
{
    public class LevelPositionRepository
    {
        private string _connectionString;

        public LevelPositionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<LevelsPositionDTO> GetAll()
        {
            string query = "GetLevelPositions";
            List<LevelsPositionDTO> result = new List<LevelsPositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<LevelsPositionDTO>(query).AsList<LevelsPositionDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Create(LevelsPositionDTO levelPosition)
        {
            string query = "CreateLevelPosition @Title @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { levelPosition.Title, levelPosition.Description });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(LevelsPositionDTO levelPosition)
        {
            string query = "UpdateLevelPosition @ID @Title @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        levelPosition.ID,
                        levelPosition.Title,
                        levelPosition.Description
                    });
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
            string query = "DeleteLevelPosition @ID";
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

        public LevelsPositionDTO GetByID(int id)
        {
            string query = "GetLevelPositionsByID @ID";
            LevelsPositionDTO result = new LevelsPositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<LevelsPositionDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public LevelsPositionDTO GetByTitle(string title)
        {
            string query = "GetLevelPositionsByTitle @Title";
            LevelsPositionDTO result = new LevelsPositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<LevelsPositionDTO>(query, new { title });
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
