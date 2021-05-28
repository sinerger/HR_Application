using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class FamilyStatusRepository
    {
        private string _connectionString;

        public FamilyStatusRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public FamilyStatusDTO GetByID(int id)
        {
            string query = "GetFamilyStatusByID @ID";
            FamilyStatusDTO result = new FamilyStatusDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<FamilyStatusDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public List<FamilyStatusDTO> GetAll()
        {
            string query = "GetFamilyStatuses";
            List<FamilyStatusDTO> result = new List<FamilyStatusDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<FamilyStatusDTO>(query).AsList<FamilyStatusDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Create(FamilyStatusDTO familyStatus)
        {
            string query = "CreateFamilyStatus @Status";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { familyStatus.Status });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(FamilyStatusDTO familyStatus)
        {
            string query = "UpdateFamilyStatus @ID @Status";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new { familyStatus.ID, familyStatus.Status });
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
            string query = "DeleteFamilyStatus @ID";
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