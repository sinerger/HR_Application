using Dapper;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace HR_Application_DB_Logic.Repositories
{
    public class LevelSkillRepository
    {
        private string _connectionString;

        public LevelSkillRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool Create(LevelSkillDTO levelSkill)
        {
            string query = "CreateLevelSkills @Title";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { levelSkill.Title });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(LevelSkillDTO levelSkill)
        {
            string query = "UpdateLevelSkills @ID @Title";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { levelSkill.ID, levelSkill.Title });
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
            string query = "DeleteLevelSkills @ID";
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

        public List<LevelSkillDTO> GetAll()
        {
            string query = "GetLevelSkills";
            List<LevelSkillDTO> result = new List<LevelSkillDTO>();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.Query<LevelSkillDTO>(query, commandType: CommandType.StoredProcedure).ToList<LevelSkillDTO>();
            }

            return result;
        }

        public LevelSkillDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetLevelSkillsByID @ID";
            LevelSkillDTO result = new LevelSkillDTO();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<LevelSkillDTO>(query, new { id });
                }
            }
            catch(Exception e)
            {
                var s = e.ToString();
            }

            return result;
        }

        public LevelSkillDTO GetByTitle(string title)
        {
            string query = "GetLevelSkillsByTitle @Title";
            LevelSkillDTO result = new LevelSkillDTO();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.QuerySingle<LevelSkillDTO>(query, new { title });
            }

            return result;
        }
    }
}
