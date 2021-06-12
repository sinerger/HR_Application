using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class CommentRepository : IRepository<CommentDTO>
    {
        public string ConnectionString { get; private set; }

        public CommentRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public CommentDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetCommentByID";
            CommentDTO result = new CommentDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<CommentDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public List<CommentDTO> GetAll()
        {
            string query = "[HRAppDB].GetComments";
            List<CommentDTO> result = new List<CommentDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<CommentDTO>(query).AsList<CommentDTO>();
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
            string query = "[HRAppDB].DeleteComment @ID";
            bool result = true;

            try
            {
                using(IDbConnection dbConnection = new SqlConnection(ConnectionString))
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

        public int Create(CommentDTO comment)
        {
            int returnID = 0;
            string query = "[HRAppDB].CreateComment @EmployeeID, @Information, @Date";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.QuerySingle<int>(query, new
                    {
                        comment.EmployeeID,
                        comment.Information,
                        comment.Date
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }

        public bool Update(CommentDTO comment)
        {
            string query = "[HRAppDB].UpdateComment @ID, @EmployeeID, @Information, @Date";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        comment.ID,
                        comment.EmployeeID,
                        comment.Information,
                        comment.Date
                    });
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