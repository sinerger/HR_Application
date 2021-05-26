using Dapper;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic
{
    public static class DBController
    {
        private static string _connectionString = @"Server=(LocalDB)\MSSQLLocalDB; DataBase = NewEmployeesDB; Trusted_Connection = True; Integrated Security = True;";

        public static List<GeneralInformationDTO> GetGeneralInformationDTOByEmployeeID(int employeeID)
        {
            string query = "exec GetGeneralInformationByEmployeeID @employeeID";
            var result = new List<GeneralInformationDTO>();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.Query<GeneralInformationDTO>(query, new { employeeID }).AsList<GeneralInformationDTO>();
            }

            return result;
        }

        public static EmployeeDTO GetEmployeeDTOByID(int id)
        {
            string query = "exec GetEmployeeByID @ID";

            var result = new EmployeeDTO();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.QuerySingle<EmployeeDTO>(query, new { id });
            }

            return result;
        }

        public static SkillDTO GetSkillDTOByID(int ID)
        {
            string query = "exec GetSkillDTOByID @ID";
            var result = new SkillDTO();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.QuerySingle<SkillDTO>(query, new { ID });
            }

            return result;
        }

        public static SkillDTO GetSkillDTOByTitle(string title)
        {
            string query = "exec GetSkillDTOByTitle @Title";
            var result = new SkillDTO();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.QuerySingle<SkillDTO>(query, new { title });
            }

            return result;
        }

        public static List<SkillDTO> GetAllSkillsDTO()
        {
            string query = "exec GetAllSkillsDTO";
            var result = new List<SkillDTO>();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.Query<SkillDTO>(query).AsList<SkillDTO>();
            }

            return result;
        }

        public static FamilyStatusDTO GetFamilyStatusDTOByID(int ID)
        {
            string query = "exec GetFamilyStatusDTOByID @ID";
            var result = new FamilyStatusDTO();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.QuerySingle<FamilyStatusDTO>(query, new { ID });
            }

            return result;
        }

        public static List<FamilyStatusDTO> GetAllFamilyStatusesDTO()
        {
            string query = "exec GetAllFamilyStatusesDTO";
            var result = new List<FamilyStatusDTO>();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.Query<FamilyStatusDTO>(query).AsList<FamilyStatusDTO>();
            }

            return result;
        }
    }
}
