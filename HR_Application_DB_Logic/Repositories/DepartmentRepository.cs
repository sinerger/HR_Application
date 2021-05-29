using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HR_Application_DB_Logic.Models;

namespace HR_Application_DB_Logic.Repositories
{
    public class DepartmentRepository
    {
        private string _connectionString;

        public DepartmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DepartmentDTO GetByID(int ID)
        {
            string query = "GetDepartmentByID @ID";
            var result = new DepartmentDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<DepartmentDTO>(query, new { ID });
                }
            }
            catch
            {
                result = null;
            }
            

            return result;
        }

        public List<DepartmentDTO> GetAll()
        {
            string query = "GetDepartments";
            var result = new List<DepartmentDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<DepartmentDTO>(query).AsList<DepartmentDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Create(DepartmentDTO department)
        {
            string query = "CreateDepartment @Title @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { department.Title, department.Description });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(DepartmentDTO department)
        {
            string query = "UpdateDepartment @ID @Title @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { department.ID, department.Title, department.Description });
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
           string query = "DeleteDepartmen @ID";
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
    }
}
