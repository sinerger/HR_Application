﻿using Dapper;
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

        public SkillDTO GetByID(int id)
        {
            string query = "GetSkillByID @ID";
            SkillDTO result = new SkillDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<SkillDTO>(query, new { id });
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
            SkillDTO result = new SkillDTO();

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
            string query = "GetSkills";
            List<SkillDTO> result = new List<SkillDTO>();

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

        public bool Create(SkillDTO skill)
        {
            string query = "CreateSkill @Title @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { skill.Title, skill.Description });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(SkillDTO skill)
        {
            string query = "UpdateSkillByID @ID @Title @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { skill.ID, skill.Title, skill.Description });
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
            string query = "DeleteSkill @ID";
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