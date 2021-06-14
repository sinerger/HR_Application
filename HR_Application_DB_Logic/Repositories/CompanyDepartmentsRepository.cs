using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using System;
using HR_Application_DB_Logic.Models.Base;

namespace HR_Application_DB_Logic.Repositories
{
    public class CompanyDepartmentsRepository : IRepository<CompanyDepartmentsDTO>
    {
        public string ConnectionString { get; private set; }

        public CompanyDepartmentsRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<CompanyDepartmentsDTO> GetAll()
        {
            string query = "[HRAppDB].GetCompaniesDepartments";
            List<CompanyDepartmentsDTO> companiesDepartments = new List<CompanyDepartmentsDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Query<CompanyDepartmentsDTO, int, CompanyDepartmentsDTO>(query,
                        (companyDepartment, departmentID) =>
                        {
                            CompanyDepartmentsDTO currentCompany = null;

                            foreach (var companyDep in companiesDepartments)
                            {
                                if (companyDep.CompanyID == companyDepartment.CompanyID)
                                {
                                    companyDep.DepartmentsID.Add(departmentID);
                                    currentCompany = companyDep;
                                    break;
                                }
                            }

                            if (currentCompany == null)
                            {
                                companyDepartment.DepartmentsID = new List<int>();
                                companyDepartment.DepartmentsID.Add(departmentID);
                                currentCompany = companyDepartment;

                                companiesDepartments.Add(currentCompany);
                            }

                            return currentCompany;
                        }).AsList<CompanyDepartmentsDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return companiesDepartments;
        }

        public CompanyDepartmentsDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetCompanyDepartmentsByCompanyID @ID";
            CompanyDepartmentsDTO companyDepartments = null;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Query<CompanyDepartmentsDTO, int, CompanyDepartmentsDTO>(query,
                        (companyDeps, departmentID) =>
                        {
                            if (companyDepartments == null)
                            {
                                companyDepartments = companyDeps;
                                companyDepartments.DepartmentsID = new List<int>();
                            }
                            companyDepartments.DepartmentsID.Add(departmentID);

                            return companyDeps;
                        }, new { id }).AsList<CompanyDepartmentsDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return companyDepartments;
        }

        public bool Update(CompanyDepartmentsDTO obj)
        {
            string query = "[HRAppDB].[UpdateCompanyDepartments] @ID, @DepartmentID, @CompanyID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { obj.ID, obj.DepartmentsID, obj.CompanyID });
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
            string query = "[HRAppDB].DeleteCompanyDepartments @ID";
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

        public int Create(CompanyDepartmentsDTO obj)
        {
            int returnID = 0;
            string query = "[HRAppDB].CreateCompanyDepartments @DepartmentID, @CompanyID, @IsActual";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    returnID = dbConnection.QuerySingle<int>(query, new { obj.DepartmentsID, obj.CompanyID, obj.IsActual });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }

        public List<int> CreateList(CompanyDepartmentsDTO obj)
        {
            List<int> returnID = new List<int>();
            string query = "[HRAppDB].CreateCompanyDepartments @CompanyID, @DepartmentID, @IsActual";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    for (int i = 0; i < obj.DepartmentsID.Count; i++)
                    {
                        var DepartmentID = obj.DepartmentsID[i];
                        returnID.Add(dbConnection.QuerySingle<int>(query, new
                        {
                            obj.CompanyID,
                            DepartmentID,
                            obj.IsActual
                        }));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }
    }
}