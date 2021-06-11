using Dapper;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeeStatusRepository
    {
        private string _connectionString;

        public EmployeeStatusRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<EmployeeStatusDTO> GetAll()
        {
            string query = "[HRAppDB].GetEmployeeStatuses";
            List<EmployeeStatusDTO> result = new List<EmployeeStatusDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<EmployeeStatusDTO, StatusDTO, EmployeeStatusDTO>
                        (query,
                        (employeeStatus, status) =>
                        {
                            employeeStatus.Status = status;

                            return employeeStatus;
                        },
                        splitOn: "ID, IDStatuses")
                        .AsList<EmployeeStatusDTO>();
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