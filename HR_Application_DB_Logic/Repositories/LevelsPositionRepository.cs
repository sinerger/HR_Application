using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Interfaces;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class LevelsPositionRepository : IRepository<LevelsPositionDTO>
    {
       public string ConnectionString { get; private set; }

        public LevelsPositionRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<LevelsPositionDTO> GetAll()
        {
            string query = "[HRAppDB].GetLevelPositions";
            List<LevelsPositionDTO> result = new List<LevelsPositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<LevelsPositionDTO>(query).AsList<LevelsPositionDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public int Create(LevelsPositionDTO levelsPosition)
        {
            string query = "[HRAppDB].CreateLevelPosition @Title, @Description";
            int returnID = 0;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.QuerySingle<int>(query, new { levelsPosition.Title, levelsPosition.Description });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }

        public bool Update(LevelsPositionDTO levelsPosition)
        {
            string query = "[HRAppDB].UpdateLevelPosition @ID, @Title, @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        levelsPosition.ID,
                        levelsPosition.Title,
                        levelsPosition.Description
                    });
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
            string query = "[HRAppDB].DeleteLevelsPosition @ID";
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

        public LevelsPositionDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetLevelsPositionsByID @ID";
            LevelsPositionDTO result = new LevelsPositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<LevelsPositionDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public LevelsPositionDTO GetByTitle(string title)
        {
            string query = "[HRAppDB].GetLevelPositionsByTitle @Title";
            LevelsPositionDTO result = new LevelsPositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<LevelsPositionDTO>(query, new { title });
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