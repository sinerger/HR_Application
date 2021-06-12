using Dapper;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeeProjectRepository
    {
        private string _connectionString;

        public EmployeeProjectRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<EmployeesProjectsDTO> GetALL()
        {
            string query = "[HRAppDB].GetEmployeesProjects";
            List<EmployeesProjectsDTO> employeesProjects = new List<EmployeesProjectsDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<EmployeesProjectsDTO, int, EmployeesProjectsDTO>(query,
                        (employeeProjects, projectID) =>
                        {
                            EmployeesProjectsDTO currentEP = null;

                            foreach (EmployeesProjectsDTO currentEmployeePr in employeesProjects)
                            {
                                if (currentEmployeePr.EmployeeID == employeeProjects.EmployeeID)
                                {
                                    currentEP = employeeProjects;
                                    currentEP.ProjectsID.Add(projectID);
                                    break;
                                }
                            }

                            if (currentEP == null)
                            {
                                currentEP = employeeProjects;
                                employeesProjects.Add(currentEP);
                                currentEP.ProjectsID = new List<int>();
                                currentEP.ProjectsID.Add(projectID);
                            }

                            return employeeProjects;
                        }).AsList<EmployeesProjectsDTO>();
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
            List<EmployeesProjectsDTO> employeesProjects = new List<EmployeesProjectsDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<EmployeesProjectsDTO, int, EmployeesProjectsDTO>(query,
                        (employeeProjects, projectID) =>
                        {
                            EmployeesProjectsDTO currentEP = null;

                            foreach (EmployeesProjectsDTO currentEmployeePr in employeesProjects)
                            {
                                if (currentEmployeePr.EmployeeID == employeeProjects.EmployeeID)
                                {
                                    currentEP = employeeProjects;
                                    currentEP.ProjectsID.Add(projectID);
                                    break;
                                }
                            }

                            if (currentEP == null)
                            {
                                currentEP = employeeProjects;
                                employeesProjects.Add(currentEP);
                                currentEP.ProjectsID = new List<int>();
                                currentEP.ProjectsID.Add(projectID);
                            }

                            return employeeProjects;
                        }, new { id })
                        .AsList<EmployeesProjectsDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return employeesProjects[0];
        }
    }
}
