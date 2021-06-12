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
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
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

        public bool Update(EmployeesProjectsDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
