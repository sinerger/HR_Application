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

        public static List<PositionDTO> GetPositions()
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "crud_PositionsRead";
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            return db.Query<PositionDTO>(query, commandType: CommandType.StoredProcedure).AsList<PositionDTO>();
        }

        public static List<PositionDTO> GetPositionById(int positionID)
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "GetPositionByID";
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            return db.Query<PositionDTO>(query,new { ID = positionID }, commandType: CommandType.StoredProcedure).AsList<PositionDTO>();
        }

        public static List<PositionDTO> GetPositionByTitle(string positionTitle)
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "GetPositionByTitle";
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            return db.Query<PositionDTO>(query, new { Title = positionTitle }, commandType: CommandType.StoredProcedure).AsList<PositionDTO>();
        }



        public static DepartmentDTO GetDepartmentDTOByID(int ID)
        {
            string query = "exec GetDepartmentDTOByID @ID";
            var result = new DepartmentDTO();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.QuerySingle<DepartmentDTO>(query, new { ID });
            }

            return result;
        }

        public static List<DepartmentDTO> GetAllDepartmentsDTO()
        {
            string query = "exec GetAllDepartmentsDTO";
            var result = new List<DepartmentDTO>();

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                result = dbConnection.Query<DepartmentDTO>(query).AsList<DepartmentDTO>();
            }

            return result;
        }
    }
}
