using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace HR_Application_DB_Logic.Repositories
{
    public class LevelSkillRepository : IRepository<LevelSkillDTO>
    {
        public string ConnectionString { get; private set; }

        public LevelSkillRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public int Create(LevelSkillDTO levelSkill)
        {
            string query = "[HRAppDB].CreateLevelSkill @ID, @Title";
            int returnID = 0;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { levelSkill.ID, levelSkill.Title });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }

        public bool Delete(int id)
        {
            string query = "[HRAppDB].DeleteLevelSkill @ID";
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

        public List<LevelSkillDTO> GetAll()
        {
            string query = "[HRAppDB].GetLevelSkills";
            List<LevelSkillDTO> result = new List<LevelSkillDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<LevelSkillDTO>(query).AsList<LevelSkillDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public LevelSkillDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetLevelSkillByID @ID";
            LevelSkillDTO result = new LevelSkillDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<LevelSkillDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Update(LevelSkillDTO levelSkill)
        {
            string query = "[HRAppDB].UpdateLevelSkill @ID, @Title";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { levelSkill.ID, levelSkill.Title });
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
