using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_Application_DB_Logic.Models;

namespace HR_Application_DB_Logic.Repositories
{
    public class RequirementRepository
    {
        private string _connectionString;

        public RequirementRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<RequirementDTO> GetAll()
        {
            List<RequirementDTO> result = new List<RequirementDTO>();
            string query = "GetRequirements";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<RequirementDTO>(query).AsList<RequirementDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public RequirementDTO GetById(int id)
        {
            string query = "GetRequirementByID @ID";
            RequirementDTO result = new RequirementDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<RequirementDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Create(RequirementDTO requirement)
        {
            string query = "CreateRequirements @SkillID, @LevelSkillID, @AmountOfEmployees";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        requirement.SkillID,
                        requirement.LevelSkillID,
                        requirement.AmountOfEmployees
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(RequirementDTO requirement)
        {
            string query = "UpdateRequirements @ID, @SkillID, @LevelSkillID, @AmountOfEmployees";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        requirement.ID,
                        requirement.SkillID,
                        requirement.LevelSkillID,
                        requirement.AmountOfEmployees
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
            string query = "DeleteRequirements @ID";
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
    }
}
