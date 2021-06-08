using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using Dapper;
using System;

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
                    result = dbConnection.Query<CompanyDepartmentsDTO, int, DepartmentDTO, CompanyDepartmentsDTO>(query,
                        (companyDepartment, companyID, department) =>
                        {
                            companyDepartment.CompanyID = companyID;
                            companyDepartment.Departments = new List<DepartmentDTO>();
                            companyDepartment.Departments.Add(department);

                            return companyDepartment;
                        })
                        .AsList<CompanyDepartmentsDTO>();
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return result;
        }

        public List<CompanyDepartmentsDTO> GetALLByCompanyID(int id)
        {
            string query = "[HRAppDB].GetCompanyDepartmentsByCompanyID @ID";
            List<CompanyDepartmentsDTO> companyDepartments = new List<CompanyDepartmentsDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Query<CompanyDepartmentsDTO, int, DepartmentDTO, CompanyDepartmentsDTO>(query,
                        (companyDepartment, companyID, department) =>
                        {
                            CompanyDepartmentsDTO currentCD = null;

                            foreach (CompanyDepartmentsDTO cD in companyDepartments)
                            {
                                if (cD.CompanyID == companyID)
                                {
                                    currentCD = companyDepartment;
                                    cD.Departments.Add(department);
                                    break;
                                }
                            }

                            if (currentCD == null)
                            {
                                currentCD = companyDepartment;
                                companyDepartments.Add(currentCD);
                                currentCD.CompanyID = companyID;
                                currentCD.Departments = new List<DepartmentDTO>();
                                currentCD.Departments.Add(department);
                            }

                            return companyDepartment;
                        }, new { id })
                        .AsList<CompanyDepartmentsDTO>();
                }
            }
            catch ( Exception e)
            {
                throw e;
            }

            return companyDepartments;
        }
    }
}
