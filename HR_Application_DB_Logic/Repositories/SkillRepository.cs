using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Interfaces;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class SkillRepository: IRepository<SkillDTO>
    {
        public string ConnectionString { get; private set; }

        public SkillRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool Create(SkillDTO skill)
        {
            string query = "[HRAppDB].CreateSkill @Title, @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { skill.Title, skill.Description });
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
            string query = "[HRAppDB].DeleteSkill @ID";
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

        public List<SkillDTO> GetAll()
        {
            string query = "[HRAppDB].GetSkills";
            List<SkillDTO> result = new List<SkillDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<SkillDTO>(query).AsList<SkillDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public SkillDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetSkillByID @ID";
            SkillDTO result = new SkillDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<SkillDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Update(SkillDTO skill)
        {
            string query = "[HRAppDB].UpdateSkill @ID, @Title, @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { skill.ID, skill.Title, skill.Description });
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