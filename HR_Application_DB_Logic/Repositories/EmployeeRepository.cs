using Dapper;
using HR_Application_DB_Logic.Models;
using System.Collections.Generic;
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

        public List<EmployeeDTO> GetAll()
        {
            string query = "GetEmployees";
            List<EmployeeDTO> result = new List<EmployeeDTO>();

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

        public bool Create(EmployeeDTO employee)
        {
            bool result = true;
            string query = "CreateEmployees @Photo, @FirstName, @LastName, @RegistationDate, @StatusID, @LocationID, @IsActual";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        employee.Photo,
                        employee.FirstName,
                        employee.LastName,
                        employee.RegistrationDate,
                        employee.StatusID,
                        employee.LocationID,
                        employee.IsActual
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(EmployeeDTO employee)
        {
            bool result = true;
            string query = "UpdateEmployees @ID, @Photo, @FirstName, @LastName, @RegistationDate, @StatusID, @LocationID, @IsActual";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        employee.ID,
                        employee.Photo,
                        employee.FirstName,
                        employee.LastName,
                        employee.RegistrationDate,
                        employee.StatusID,
                        employee.LocationID,
                        employee.IsActual
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = true;
            string query = "DeleteEmployees @ID";

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
    }
}
