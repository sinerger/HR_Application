using Dapper;
using HR_Application_DB_Logic.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class SkillRepository
    {
        private string _connectionString;

        public SkillRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public  SkillDTO GetByID(int ID)
        {
            string query = "GetSkillByID @ID";
            var result = new SkillDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<SkillDTO>(query, new { ID });
                }
            }
            catch
            {
                result = null;
            }
            

            return result;
        }

        public SkillDTO GetByTitle(string title)
        {
            string query = " GetSkillByTitle @Title";
            var result = new SkillDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<SkillDTO>(query, new { title });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public List<SkillDTO> GetAll()
        {
            string query = "GetAllSkillsDTO";
            var result = new List<SkillDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<SkillDTO>(query).AsList<SkillDTO>();
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
