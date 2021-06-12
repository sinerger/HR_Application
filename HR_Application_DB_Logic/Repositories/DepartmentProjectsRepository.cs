using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using System;
using HR_Application_DB_Logic.Models.Base;

namespace HR_Application_DB_Logic.Repositories
{
    public class DepartmentProjectsRepository : IRepository<DepartmentProjectsDTO>
    {
        public string ConnectionString { get; private set; }

        public DepartmentProjectsRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<DepartmentProjectsDTO> GetAll()
        {
            string query = "[HRAppDB].GetDepartmentsProjects";
            List<DepartmentProjectsDTO> departmentsProjects = new List<DepartmentProjectsDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Query<DepartmentProjectsDTO, int, DepartmentProjectsDTO>(query,
                        (departmentProject, projectID) =>
                        {
                            DepartmentProjectsDTO currentDP = null;

                            foreach (var dp in departmentsProjects)
                            {
                                if (dp.ID == departmentProject.ID)
                                {
                                    dp.ProjectsID.Add(projectID);
                                    currentDP = dp;
                                    break;
                                }
                            }

                            if (currentDP == null)
                            {
                                departmentProject.ProjectsID = new List<int>();
                                departmentProject.ProjectsID.Add(projectID);
                                currentDP = departmentProject;

                                departmentsProjects.Add(departmentProject);
                            }

                            return currentDP;
                        }).AsList<DepartmentProjectsDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return departmentsProjects;
        }

        public DepartmentProjectsDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetDepartmentProjectsByDepartmentID @ID";
            DepartmentProjectsDTO departmentProject = null;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Query<DepartmentProjectsDTO, int, DepartmentProjectsDTO>(query,
                        (dp, projectID) =>
                        {
                            if (departmentProject == null)
                            {
                                departmentProject = dp;
                                departmentProject.ProjectsID = new List<int>();
                            }
                            departmentProject.ProjectsID.Add(projectID);

                            return departmentProject;
                        }, new { id }).AsList<DepartmentProjectsDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return departmentProject;
        }

        public bool Update(DepartmentProjectsDTO obj)
        {
            string query = "[HRAppDB].[UpdateDepartmentsProjects] @ID, @ProjectID, @DepartmentID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { obj.ID, obj.ProjectsID, obj.DepartmentID });
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
            string query = "[HRAppDB].DeleteDepartmentsProjects @ID";
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

        public int Create(DepartmentProjectsDTO obj)
        {
            string query = "[HRAppDB].CreateDepartmentsProjects @ProjectID, @DepartmentID, @IsActual";
            int returnID = 0;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.QuerySingle<int>(query, new { obj.ProjectsID, obj.DepartmentID, obj.IsActual });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }
    }
}
