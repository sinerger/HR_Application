using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeeRepository : IRepository<EmployeeDTO>
    {
        private string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Create(EmployeeDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            string query = "DeleteEmployeeByID";
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


        public IEnumerable<EmployeeDTO> GetAllDTO()
        {
            string query = "GetEmployeeByID @ID";
            var result = new List<EmployeeDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<EmployeeDTO>(query).AsList<EmployeeDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public EmployeeDTO GetDTOByID(int id)
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

            }

            return result;
        }

        public void Update(EmployeeDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
