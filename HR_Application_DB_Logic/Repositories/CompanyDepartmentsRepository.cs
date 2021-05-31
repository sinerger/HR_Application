using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using Dapper;

namespace HR_Application_DB_Logic.Repositories
{
    public class CompanyDepartmentsRepository
    {
        private string _connectionString;

        public CompanyDepartmentsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<CompanyDepartmentsDTO> GetALL()
        {
            string query = "[HRAppDB].GetCompaniesDepartments";
            List<CompanyDepartmentsDTO> result = new List<CompanyDepartmentsDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<CompanyDepartmentsDTO, CompanyDTO, int, CompanyDepartmentsDTO>(query,
                        (companyDepartment, company, departmentID) =>
                        {
                            companyDepartment.Company = company;
                            companyDepartment.DepartmentsID = new List<int>();
                            companyDepartment.DepartmentsID.Add(departmentID);

                            return companyDepartment;
                        }
                        , splitOn: "IDD,ID,IDDepartment")
                        .AsList<CompanyDepartmentsDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public List<CompanyDepartmentsDTO> GetALLByCompanyID(int companyID)
        {
            string query = "[HRAppDB].GetCompanyDepartmentsByCompanyID @CompanyID";
            List<CompanyDepartmentsDTO> companyDepartments = new List<CompanyDepartmentsDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<CompanyDepartmentsDTO, CompanyDTO, int, CompanyDepartmentsDTO>(query,
                        (companyDepartment, company, departmentID) =>
                        {
                            CompanyDepartmentsDTO currentCD = null;

                            foreach (CompanyDepartmentsDTO cD in companyDepartments)
                            {
                                if (cD.Company.ID == company.ID)
                                {
                                    currentCD = companyDepartment;
                                    cD.DepartmentsID.Add(departmentID);
                                    break;
                                }
                            }

                            if (currentCD == null)
                            {
                                currentCD = companyDepartment;
                                companyDepartments.Add(currentCD);
                                currentCD.Company = company;
                                currentCD.DepartmentsID = new List<int>();
                                currentCD.DepartmentsID.Add(departmentID);
                            }

                            return companyDepartment;
                        }, new { companyID }, splitOn: "IDD,ID,IDDepartment")
                        .AsList<CompanyDepartmentsDTO>();
                }
            }
            catch
            {
                companyDepartments = null;
            }

            return companyDepartments;
        }
    }
}
