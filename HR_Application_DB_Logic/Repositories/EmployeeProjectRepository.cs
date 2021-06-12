using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeeProjectRepository : IRepository<EmployeesProjectsDTO>
    {
        public string ConnectionString { get;private set;}

        public EmployeeProjectRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool Create(EmployeesProjectsDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeesProjectsDTO> GetAll()
        {
            string query = "[HRAppDB].GetEmployeesProjects";
            List<EmployeesProjectsDTO> employeesProjects = new List<EmployeesProjectsDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    employeesProjects = dbConnection.Query<EmployeesProjectsDTO>(query).AsList<EmployeesProjectsDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return employeesProjects;
        }

        public EmployeesProjectsDTO GetByID(int id)
        {
            string query = "[HRAppDB].[GetEmployeeProjectByID] @ID";
            EmployeesProjectsDTO employeesProjects = new EmployeesProjectsDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    employeesProjects = dbConnection.QuerySingle<EmployeesProjectsDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return employeesProjects;
        }

        public bool Update(EmployeesProjectsDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
