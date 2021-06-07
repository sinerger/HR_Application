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
                        user.Company.ID,
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
                        user.Company,
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
                    result = dbConnection.Query<UserDTO, CompanyDTO, AdressDTO, CityDTO, CountryDTO, UserDTO>
                        (query,
                        (user, conpany, adress, city, country) =>
                        {
                            user.Company = conpany;
                            user.Adress = adress;
                            user.Adress.City = city;
                            user.Adress.Country = country;

                            return user;
                        })
                        .AsList<UserDTO>();
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
                    result = dbConnection.Query<UserDTO, CompanyDTO, AdressDTO, CityDTO, CountryDTO, UserDTO>
                        (query,
                        (user, conpany, adress, city, country) =>
                        {
                            user.Company = conpany;
                            user.Adress = adress;
                            user.Adress.City = city;
                            user.Adress.Country = country;

                            return user;
                        }, new { id })
                        .AsList<UserDTO>()[0];
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
