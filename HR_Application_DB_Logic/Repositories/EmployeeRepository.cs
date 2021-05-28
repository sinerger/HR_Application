using Dapper;
using HR_Application_DB_Logic.Models;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeeRepository
    {
        private string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public EmployeeDTO GetByID(int id)
        {
            string query = "GetEmployeeByID @ID";

            var result = new EmployeeDTO();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<EmployeeDTO>(query, new { id });
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
