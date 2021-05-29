using Dapper;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HR_Application_DB_Logic.Repositories
{
    public class CompanyRepository
    {
        private string _connectionString;

        public CompanyRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool Create(CompanyDTO company)
        {
            string query = "CreateCompany @Title @LocationID @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { company.Title, company.LocationID, company.Description });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(CompanyDTO company)
        {
            string query = "UpdateCompany @ID @Title @LocationID @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { company.ID, company.Title, company.LocationID, company.Description });
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
            string query = "DeleteCompany @ID";
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

        public List<CompanyDTO> GetAll()
        {
            string query = "GetCompanies";
            List<CompanyDTO> result = new List<CompanyDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<CompanyDTO>(query).AsList<CompanyDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public CompanyDTO GetByID(int id)
        {
            string query = "GetCompanyByID @ID";
            CompanyDTO result = new CompanyDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<CompanyDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public CompanyDTO GetByName(string Name)
        {
            string query = "GetCompanyByName @Name";
            CompanyDTO result = new CompanyDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<CompanyDTO>(query, new { Name });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }
    }
}
