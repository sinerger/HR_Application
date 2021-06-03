using Dapper;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
            string query = "[HRAppDB].GetEmployeeSkill";
            List<EmployeeSkillDTO> result = new List<EmployeeSkillDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<EmployeeSkillDTO, int, int, EmployeeSkillDTO>
                         (query,
                         (employeeSkill, levelSkill, skill) =>
                         {
                             employeeSkill.LevelID = levelSkill;
                             employeeSkill.SkillID = skill;

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
            string query = "[HRAppDB].GetEmployeeSkillByEmployeeID @EmployeeID";
            List<EmployeeSkillDTO> result = new List<EmployeeSkillDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<EmployeeSkillDTO, int, int, EmployeeSkillDTO>
                         (query,
                         (employeeSkill, levelSkill, skill) =>
                         {
                             employeeSkill.LevelID = levelSkill;
                             employeeSkill.SkillID = skill;

                             return employeeSkill;
                         },
                         new { employeeID },
                         splitOn: "ID,IDLevelSkills,IDSkill")
                         .AsList<EmployeeSkillDTO>();
                }
            }
            catch (Exception e)
            {
                var s = e.ToString();
                result = null;
            }

            return result;
        }
    }
}
