using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_DB_Logic.Models.Custom;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using HR_Application_DB_Logic.Models;

namespace HR_Application_DB_Logic.Repositories
{
    public class CompanyDepartmentsRepository
    {
        private string _connectionString;

        public CompanyDepartmentsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<CompanyDepartmentsDTO> GetCompaniesDepartments()
        {
            string query = "[HRAppDB].GetCompaniesDepartments";
            List<CompanyDepartmentsDTO> result = new List<CompanyDepartmentsDTO>();
            
            using(IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                var companiesDepartments = new IDictionary<int, Company>();

                result = dbConnection.Query<CompanyDTO, DepartmentDTO, CompanyDepartmentsDTO>
                    (query,
                    (company, department) =>
                    {
                        CompanyDTO curCompany = null;
                        DepartmentDTO curDepartment = null;

                    }.AsList<CompaniesDepartmentsDTO>();
            }

            return result;
        }
        
    }
}
