using HR_Application_DB_Logic.Models;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class ProjectRepository
    {
        private string _connectionString;
        public string query;

        public ProjectRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ProjectDTO> GetAll()
        {
            query = "GetProjects";
            List<ProjectDTO> result = new List<ProjectDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<ProjectDTO>(query).AsList<ProjectDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public ProjectDTO GetByID(int id)
        {
            query = "GetProjectByID";
            ProjectDTO result = new ProjectDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<ProjectDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public List<ProjectDTO> GetByTitle(ProjectDTO project)
        {
            query = "GetProjectByTitle";
            List<ProjectDTO> result = new List<ProjectDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<ProjectDTO>(query, new { project.Title }).AsList<ProjectDTO>();
                }
            }
            catch
            {
                return null;
            }

            return result;
        }

        public bool Create (ProjectDTO project)
        {
            query = "CreateProjects @Title, @Description, @DirectionID";
            bool result = true;

            try
            {
                using(IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new 
                    {
                        project.Title,
                        project.Description,
                        project.DirectionID 
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(ProjectDTO project)
        {
            query = "CreateProjects @ID, @Title, @Description, @DirectionID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
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
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Delete(int id)
        {
            query = "DeleteProjects @ID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { id });
                }
            }
            catch
            {
                return false;
            }

            return result;
        }
    }
}
