using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using Dapper;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeesPositionRepository
    {
        private string _connectionString;

        public EmployeesPositionRepository(string connectionString)
        {
            connectionString = _connectionString;
        }

        public List<EmployeesPositionDTO> GetAll()
        {
            string query = "GetEmployeesPosition";
            List<EmployeesPositionDTO> result = new List<EmployeesPositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<EmployeesPositionDTO>(query).AsList<EmployeesPositionDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Create(EmployeesPositionDTO employeePosition)
        {
            string query = "CreateEmployeePosition @EmployeeID @HiredDate @FiredDate @IsActual @LevelPositionID @PositionID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        employeePosition.EmployeeID,
                        employeePosition.HiderDate,
                        employeePosition.FiredDate,
                        employeePosition.IsActual,
                        employeePosition.LevelPosition,
                        employeePosition.Position
                    });
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
