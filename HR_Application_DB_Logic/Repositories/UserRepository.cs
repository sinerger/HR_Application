using Dapper;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HR_Application_DB_Logic.Repositories
{
    public class UserRepository
    {
        private string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool Create(UserDTO user)
        {
            string query = "CreateUsers @FirstName @LastName @CompanyID @Email @Password @IsActual";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        user.FirstName,
                        user.LastName,
                        user.CompanyID,
                        user.Email,
                        user.Password,
                        user.IsActual
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(UserDTO user)
        {
            string query = "UpdateUsers @ID @FirstName @LastName @CompanyID @Email @Password @IsActual";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        user.ID,
                        user.FirstName,
                        user.LastName,
                        user.CompanyID,
                        user.Email,
                        user.Password,
                        user.IsActual
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
            string query = "DeleteUsers @ID";
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
                result = false;
            }

            return result;
        }

        public List<UserDTO> GetAll()
        {
            string query = "GetAllUsers";
            List<UserDTO> result = new List<UserDTO>();

            using (IDbConnection dbConnection = new SqlConnection(AppConnection.ConnectionString))
            {
                result = dbConnection.Query<UserDTO>(query, commandType: CommandType.StoredProcedure).ToList<UserDTO>();
            }

            return result;
        }

        public UserDTO GetByID(int id)
        {
            string query = "GetUserByID @ID";
            UserDTO result = new UserDTO();

            using (IDbConnection dbConnection = new SqlConnection(AppConnection.ConnectionString))
            {
                result = dbConnection.QuerySingle<UserDTO>(query, new { id });
            }

            return result;
        }

        public UserDTO GetByName(string name)
        {
            string query = "GetUserByName @Name";
            UserDTO result = new UserDTO();

            using (IDbConnection dbConnection = new SqlConnection(AppConnection.ConnectionString))
            {
                result = dbConnection.QuerySingle<UserDTO>(query, new { name });
            }

            return result;
        }
    }
}
