using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class CompanyRepository : IRepository<CompanyDTO>
    {
        public string ConnectionString { get; private set; }

        public CompanyRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public int Create(CompanyDTO company)
        {
            int returnID = 0;
            string query = "[HRAppDB].CreateCompany @Title, @LocationID, @Description, @IsActual";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.QuerySingle<int>(query, new 
                    { 
                        company.Title,
                        company.LocationID,
                        company.Description,
                        company.IsActual
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }

        public bool Update(CompanyDTO company)
        {
            string query = "[HRAppDB].UpdateCompany @ID, @Title, @LocationID, @Description, @IsActual";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new
                    { 
                        company.ID,
                        company.Title,
                        company.LocationID,
                        company.Description,
                        company.IsActual
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
            string query = "[HRAppDB].DeleteCompany @ID";
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

        public List<CompanyDTO> GetAll()
        {
            string query = "[HRAppDB].GetCompanies";
            List<CompanyDTO> result = new List<CompanyDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<CompanyDTO>(query).AsList<CompanyDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public CompanyDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetCompanyByID @ID";
            CompanyDTO result = new CompanyDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<CompanyDTO>(query, new { id });
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