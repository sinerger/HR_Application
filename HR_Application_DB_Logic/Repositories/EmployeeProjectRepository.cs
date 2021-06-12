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
        public string ConnectionString { get; private set; }

        public EmployeeProjectRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public int Create(EmployeesProjectsDTO EmployeesProjects)
        {
            string query = "[HRAppDB].[CreateEmployeeProject] @EmployeeID, @ProjectID, @StartDate, @EndDate, @IsActual";
            int returnID = 0;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.QuerySingle<int>(query, new { EmployeesProjects.EmployeeID, EmployeesProjects.ProjectID, EmployeesProjects.StartDate, EmployeesProjects.EndDate, EmployeesProjects.IsActual });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }

        public bool Delete(int id)
        {
            string query = "[HRAppDB].[DeleteEmployeeProject] @ID";
            bool result = true;

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

        public List<EmployeesProjectsDTO> GetAll()
        {
            string query = "[HRAppDB].[GetEmployeesProjects]";
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

        public bool Update(EmployeesProjectsDTO EmployeesProjects)
        {
            string query = "[HRAppDB].[UpdateEmployeeProject] @ID, @EmployeeID, @ProjectID, @StartDate, @EndDate, @IsActual";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { EmployeesProjects.ID, EmployeesProjects.EmployeeID, EmployeesProjects.ProjectID, EmployeesProjects.StartDate, EmployeesProjects.EndDate, EmployeesProjects.IsActual });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}
