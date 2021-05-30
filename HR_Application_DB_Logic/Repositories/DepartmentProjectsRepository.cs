using HR_Application_DB_Logic.Models.Custom;
using HR_Application_DB_Logic.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace HR_Application_DB_Logic.Repositories
{
    public class DepartmentProjectsRepository
    {
        private string _connectionString;

        public DepartmentProjectsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<DepartmentProjectsDTO> GetDepartmentsProjects()
        {
            string query = "[HRAppDB].GetDepartmentsProjects";
            List<DepartmentProjectsDTO> result = new List<DepartmentProjectsDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<DepartmentProjectsDTO, DepartmentDTO, int, DepartmentProjectsDTO>(query,
                        (departmentProject, department, projectID) =>
                        {
                            departmentProject.Department = department;
                            departmentProject.ProjectsID = new List<int>();
                            departmentProject.ProjectsID.Add(projectID);

                            return departmentProject;
                        }
                        , splitOn: "IDDepartments_Projects,IDDepartment,ProjectID")
                        .AsList<DepartmentProjectsDTO>();
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
