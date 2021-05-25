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
        private static string _connectionString = @"Server=(LocalDB)\MSSQLLocalDB; DataBase = EmployeesDB; Trusted_Connection = True; Integrated Security = True;";

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
    }
}
