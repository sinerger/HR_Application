using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeePositionRepository : IRepository<EmployeePositionDTO>
    {
        public string ConnectionString { get; private set; }

        public EmployeePositionRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<EmployeePositionDTO> GetAll()
        {
            string query = "[HRAppDB].[GetEmployeesPositions]";

            List<EmployeePositionDTO> result = new List<EmployeePositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<EmployeePositionDTO>(query).AsList<EmployeePositionDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public EmployeePositionDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(EmployeePositionDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Create(EmployeePositionDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}