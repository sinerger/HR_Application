using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeeRepository :IRepository<EmployeeDTO>
    {
        public string ConnectionString { get; private set; }

        public EmployeeRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public EmployeeDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetEmployeeByID @ID";

            var result = new EmployeeDTO();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<EmployeeDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public List<EmployeeDTO> GetAll()
        {
            string query = "[HRAppDB].GetEmployees";
            List<EmployeeDTO> result = new List<EmployeeDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<EmployeeDTO>(query).AsList<EmployeeDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Update(EmployeeDTO employee)
        {
            bool result = true;
            string query = "[HRAppDB].UpdateEmployees @ID, @Photo, @FirstName, @LastName, @RegistationDate, @StatusID, @LocationID, @IsActual";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
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
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = true;
            string query = "[HRAppDB].DeleteEmployees @ID";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public int Create(EmployeeDTO employee)
        {
            int retunrID = 0;
            string query = "[HRAppDB].CreateEmployees @Photo, @FirstName, @LastName, @RegistrationDate, @StatusID, @LocationID, @IsActual";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    retunrID = dbConnection.QuerySingle<int>(query, new
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
            catch (Exception e)
            {
                throw e;
            }

            return retunrID;
        }
    }
}
