using Dapper;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeeSkillRepository
    {
        private string _connectionString;

        public EmployeeSkillRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<EmployeeSkillDTO> GetAll()
        {
            string query = "[HRAppDB].SkillsLevelSkills";
            List<EmployeeSkillDTO> result = new List<EmployeeSkillDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<EmployeeSkillDTO, LevelSkillDTO, SkillDTO, EmployeeSkillDTO>
                         (query,
                         (employeeSkill, levelSkill, skill) =>
                         {
                             employeeSkill.Level = levelSkill;
                             employeeSkill.Skill = skill;

                             return employeeSkill;
                         },
                         splitOn: "ID,IDLevelSkills,IDSkill")
                         .AsList<EmployeeSkillDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }
        public List<EmployeeSkillDTO> GetAllByEmployeeID(int employeeID)
        {
            string query = "[HRAppDB].GetEmployeeSkillByEmployeeID";
            List<EmployeeSkillDTO> result = new List<EmployeeSkillDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<EmployeeSkillDTO, LevelSkillDTO, SkillDTO, EmployeeSkillDTO>
                         (query,
                         (employeeSkill, levelSkill, skill) =>
                         {
                             employeeSkill.Level = levelSkill;
                             employeeSkill.Skill = skill;

                             return employeeSkill;
                         },
                         new { employeeID },
                         splitOn: "ID,IDLevelSkills,IDSkill")
                         .AsList<EmployeeSkillDTO>();
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
