using Dapper;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HR_Application_DB_Logic.Repositories
{
    public class CommentRepository
    {
        private string _connectionString;

        public CommentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public CommentDTO GetByID(int id)
        {
            string query = "GetCommentByID";
            CommentDTO result = new CommentDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<CommentDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public CommentDTO GetByEmployeeID(int id)
        {
            string query = "GetCommentByEmployeeID";
            CommentDTO result = new CommentDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<CommentDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public List<CommentDTO> GetAll()
        {
            string query = "GetComments";
            List<CommentDTO> result = new List<CommentDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<CommentDTO>(query).AsList<CommentDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Delete(int id)
        {
            string query = "DeleteComment @ID";
            bool result = true;

            try
            {
                using(IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { id });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Create(CommentDTO comment)
        {
            string query = "CreateComment @EmployeeID @Information @Date";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        comment.EmployeeID,
                        comment.Information,
                        comment.Date
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(CommentDTO comment)
        {
            string query = "UpdateComment @ID @EmployeeID @Information @Date";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
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
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
