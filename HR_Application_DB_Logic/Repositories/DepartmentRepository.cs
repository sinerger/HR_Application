using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class DepartmentRepository : IRepository<DepartmentDTO>
    {
        public string ConnectionString { get; private set; }

        public DepartmentRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public DepartmentDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetDepartmentByID @ID";
            DepartmentDTO result = new DepartmentDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<DepartmentDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }


            return result;
        }

        public List<DepartmentDTO> GetAll()
        {
            string query = "[HRAppDB].GetDepartments";
            List<DepartmentDTO> result = new List<DepartmentDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<DepartmentDTO>(query).AsList<DepartmentDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public int Create(DepartmentDTO department)
        {
            string query = "[HRAppDB].CreateDepartment @Title, @Description";
            int returnID = 0;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    returnID =dbConnection.QuerySingle<int>(query, new { department.Title, department.Description });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }

        public bool Update(DepartmentDTO department)
        {
            string query = "[HRAppDB].UpdateDepartment @ID, @Title, @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { department.ID, department.Title, department.Description });
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
           string query = "[HRAppDB].DeleteDepartmen @ID";
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
    }
}
