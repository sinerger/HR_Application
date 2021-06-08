using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class UserRepository :IRepository<UserDTO>
    {
        public string ConnectionString { get; }

        public UserRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool Create(UserDTO user)
        {
            string query = "[HRAppDB].CreateUsers @FirstName @LastName @CompanyID @Email @Password @IsActual";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
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
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Update(UserDTO user)
        {
            string query = "[HRAppDB].UpdateUsers @ID @FirstName @LastName @CompanyID @Email @Password @IsActual";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
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
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Delete(int id)
        {
            string query = "[HRAppDB].DeleteUsers @ID";
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

        public List<UserDTO> GetAll()
        {
            string query = "[HRAppDB].GetAllUsers";
            List<UserDTO> result = new List<UserDTO>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<UserDTO>(query).AsList<UserDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public UserDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetUserByID @ID";
            UserDTO result = new UserDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<UserDTO>(query,new { id });
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
