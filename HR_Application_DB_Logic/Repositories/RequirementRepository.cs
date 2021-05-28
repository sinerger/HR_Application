using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_Application_DB_Logic.Models;

namespace HR_Application_DB_Logic.Repositories
{
    class RequirementRepository
    {
        private string _connectionString;
        private string query;

        public List<RequirementDTO> GetAll()
        {
            List<RequirementDTO> result = new List<RequirementDTO>();
            query = "GetRequirements";

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
            query = "GetRequirementByID @ID";
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
            query = "CreateRequirements @SkillID, @LevelSkillID, @AmountOfEmployees";
            bool result = true;

            try
            {
                using(IDbConnection dbConnection = new SqlConnection(_connectionString))
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
            query = "UpdateRequirements @ID, @SkillID, @LevelSkillID, @AmountOfEmployees";
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
            query = "DeleteRequirements @ID";
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
