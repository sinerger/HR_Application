using Dapper;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeeProjectsWithDirectionRepository
    {
        private string _connectionString;

        public EmployeeProjectsWithDirectionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<EmployeeProjectsWithDirectionDTO> GetALLByCompanyID(int employeeID)
        {
            string query = "[HRAppDB].GetEmployeesProjectsByEmployeeID @employeeID";
            List<EmployeeProjectsWithDirectionDTO> employeesProjects = new List<EmployeeProjectsWithDirectionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<EmployeeProjectsWithDirectionDTO,int, EmployeeProjectsWithDirectionDTO>(query,
                        (employeeProjects, projectID) =>
                        {
                            EmployeeProjectsWithDirectionDTO currentEP = null;

                            foreach (EmployeeProjectsWithDirectionDTO eP in employeesProjects)
                            {
                                if (eP.EmployeeID == employeeProjects.EmployeeID)
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
                        }
                        , new { employeeID }
                        , splitOn: "IDEmployeeProject,ProjectID")
                        .AsList<EmployeeProjectsWithDirectionDTO>();
                }
            }
            catch
            {
                employeesProjects = null;
            }

            return employeesProjects;
        }
        public List<EmployeeProjectsWithDirectionDTO> GetALL()
        {
            string query = "[HRAppDB].GetEmployeeProjects";
            List<EmployeeProjectsWithDirectionDTO> employeesProjects = new List<EmployeeProjectsWithDirectionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<EmployeeProjectsWithDirectionDTO, int, EmployeeProjectsWithDirectionDTO>(query,
                        (employeeProjects, projectID) =>
                        {
                            EmployeeProjectsWithDirectionDTO currentEP = null;

                            foreach (EmployeeProjectsWithDirectionDTO eP in employeesProjects)
                            {
                                if (eP.EmployeeID == employeeProjects.EmployeeID)
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
                        }
                        , splitOn: "IDEmployeeProject,ProjectID")
                        .AsList<EmployeeProjectsWithDirectionDTO>();
                }
            }
            catch (Exception e)
            {
                var s = e.ToString();
                employeesProjects = null;
            }

            return employeesProjects;
        }
    }
}
