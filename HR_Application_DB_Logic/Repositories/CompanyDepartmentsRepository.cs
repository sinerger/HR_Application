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
                var orderDictionary = new Dictionary<int, CompanyDTO>();


                var list = dbConnection.Query<CompanyDTO, DepartmentDTO, CompanyDepartmentsDTO>(
                    query,
                    (company, companyDepartments) =>
                    {
                        CompanyDTO curCompany;

                        if (!orderDictionary.TryGetValue(company.ID, out curCompany))
                        {
                            curCompany = company;
                            curCompany.companyDepartments = new List<CompanyDepartmentsDTO>();
                            orderDictionary.Add(curCompany.ID, curCompany);
                        }

                        curCompany..Add(curCompany);
                        return curCompany;
                    },
                    splitOn: "OrderDetailID")
                .Distinct()
                .ToList();
            }



            orderEntry.OrderDetails.Add(orderDetail);
        return orderEntry;
    },
    splitOn: "OrderDetailID")
.Distinct()
.ToList();


            return result;
        }
        
    }
}
