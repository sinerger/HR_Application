using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class ProjectRepository : IRepository<ProjectDTO>
    {
        public string ConnectionString { get; private set; }

        public ProjectRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<ProjectDTO> GetAll()
        {
            string query = "[HRAppDB].GetProjects";
            List<ProjectDTO> result = new List<ProjectDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<ProjectDTO>(query).AsList<ProjectDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public ProjectDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetProjectByID @ID";
            ProjectDTO result = new ProjectDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<ProjectDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public int Create (ProjectDTO project)
        {
            string query = "[HRAppDB].CreateProjects @Title, @Description, @DirectionID";
            int returnID = 0;

            try
            {
                using(IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    returnID = dbConnection.QuerySingle<int>(query, new 
                    {
                        project.Title,
                        project.Description,
                        project.DirectionID 
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }

        public bool Update(ProjectDTO project)
        {
            string query = "[HRAppDB].CreateProjects @ID, @Title, @Description, @DirectionID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        project.ID,
                        project.Title,
                        project.Description,
                        project.DirectionID
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
            string query = "[HRAppDB].DeleteProjects @ID";
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
    }
}