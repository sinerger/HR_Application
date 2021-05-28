using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HR_Application_DB_Logic.Repositories
{
    public class LevelSkillRepository : ILevelSkillRepository
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

        public List<LevelSkillDTO> GetLevelSkills()
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "GetLevelSkills";
            if (db.State == ConnectionState.Closed)
                db.Open();
            return db.Query<LevelSkillDTO>(query, commandType: CommandType.StoredProcedure).ToList<LevelSkillDTO>();
        }

        public List<LevelSkillDTO> GetLevelSkillsByID(int levelSkillID)
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "GetLevelSkillsByID";
            if (db.State == ConnectionState.Closed)
                db.Open();
            return db.Query<LevelSkillDTO>(query, new { ID = levelSkillID }, commandType: CommandType.StoredProcedure).AsList<LevelSkillDTO>();
        }

        public List<LevelSkillDTO> GetLevelSkillsByTitle(string LevelSkillsTitle)
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "GetLevelSkillsByTitle";
            if (db.State == ConnectionState.Closed)
                db.Open();
            return db.Query<LevelSkillDTO>(query, new { Title = LevelSkillsTitle }, commandType: CommandType.StoredProcedure).AsList<LevelSkillDTO>();
        }
    }
}
