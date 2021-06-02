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

        public List<DepartmentProjectsDTO> GetAll()
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
                        })
                        .AsList<DepartmentProjectsDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public List<DepartmentProjectsDTO> GetAllByDepartmentID(int departmentID)
        {
            string query = "[HRAppDB].GetDepartmentsProjectsByDepartmentID";
            List<DepartmentProjectsDTO> departmentProjects = new List<DepartmentProjectsDTO>();

            try
            {
                using(IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<DepartmentProjectsDTO, DepartmentDTO, int, DepartmentProjectsDTO>(query,
                        (departmentProject, department, projectID) =>
                        {
                            DepartmentProjectsDTO currentDP = null;

                            foreach (DepartmentProjectsDTO dP in departmentProjects)
                            {
                                if (dP.Department.ID == department.ID)
                                {
                                    currentDP = departmentProject;
                                    dP.ProjectsID.Add(projectID);
                                    break;
                                }
                            }

                            if (currentDP == null)
                            {
                                currentDP = departmentProject;
                                departmentProjects.Add(currentDP);
                                currentDP.Department = department;
                                currentDP.ProjectsID = new List<int>();
                                currentDP.ProjectsID.Add(projectID);
                            }

                            return departmentProject;
                        }, new { departmentID })
                        .AsList<DepartmentProjectsDTO>();
                }
            }
            catch
            {
                departmentProjects = null;
            }

            return departmentProjects;
        }
    }
}
