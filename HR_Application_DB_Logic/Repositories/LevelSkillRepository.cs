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

        public bool Insert(LevelSkillDTO levelSkill)
        {
            throw new NotImplementedException();
        }

        public bool Update(LevelSkillDTO levelSkill)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int levelSkillId)
        {
            throw new NotImplementedException();
        }

        public List<LevelSkillDTO> GetAll()
        {
            string query = "GetLevelSkills";
            List<LevelSkillDTO> result = new List<LevelSkillDTO>();

            using (IDbConnection dbConnection = new SqlConnection(AppConnection.ConnectionString))
            {
                result = dbConnection.Query<LevelSkillDTO>(query, commandType: CommandType.StoredProcedure).ToList<LevelSkillDTO>();
            }

            return result;
        }

        public LevelSkillDTO GetByID(int levelSkillID)
        {
            string query = "GetLevelSkillsByID";
            LevelSkillDTO result = new LevelSkillDTO();

            using (IDbConnection dbConnection = new SqlConnection(AppConnection.ConnectionString))
            {
                result = dbConnection.QuerySingle<LevelSkillDTO>(query, new { ID = levelSkillID });
            }

            return result;
        }

        public LevelSkillDTO GetByTitle(string LevelSkillsTitle)
        {
            string query = "GetLevelSkillsByTitle";
            LevelSkillDTO result = new LevelSkillDTO();

            using (IDbConnection dbConnection = new SqlConnection(AppConnection.ConnectionString))
            {
                result = dbConnection.QuerySingle<LevelSkillDTO>(query, new { ID = LevelSkillsTitle });
            }

            return result;
        }
    }
}
