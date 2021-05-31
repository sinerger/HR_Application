using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using Dapper;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeePositionRepository
    {
        private string _connectionString;

        public EmployeePositionRepository(string connectionString)
        {
             _connectionString = connectionString;
        }

        public List<EmployeePositionDTO> GetAll()
        {
            string query = "[HRAppDB].GetEmployeesPosition";
            List<EmployeePositionDTO> result = new List<EmployeePositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<EmployeePositionDTO, LevelsPositionDTO, PositionDTO, EmployeePositionDTO>(query,
                        (ep, levelPos, position) =>
                        {
                            ep.LevelPosition = levelPos;
                            ep.Position = position;
                            return ep;
                        })
                        .AsList<EmployeePositionDTO>();
                }
            }
            catch 
            {
                result = null;
            }

            return result;
        }
        public List<EmployeePositionDTO> GetByEmployeeID(int employeeID)
        {
            string query = "[HRAppDB].GetEmployeesPositionByEmployeeID @EmployeeID";
            List<EmployeePositionDTO> result = new List<EmployeePositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<EmployeePositionDTO, LevelsPositionDTO, PositionDTO, EmployeePositionDTO>(query,
                        (ep, levelPos, position) =>
                        {
                            ep.LevelPosition = levelPos;
                            ep.Position = position;
                            return ep;
                        },new { employeeID })
                        .AsList<EmployeePositionDTO>();
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
