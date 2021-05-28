using Dapper;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class HistoriesRepository
    {
        private string _connectionString;

        public HistoriesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool Create(HistoryDTO history)
        {
            string query = "CreateHistories @Table @CollumnName @OldValue @NewValue @UpdatedBy @Updated ";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        history.Table,
                        history.CollumnName,
                        history.OldValue,
                        history.NewValue,
                        history.UpdatedBy,
                        history.Updated
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(HistoryDTO history)
        {
            string query = "UpdateHistories @ID @Table @CollumnName @OldValue @NewValue @UpdatedBy @Updated";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        history.ID,
                        history.Table,
                        history.CollumnName,
                        history.OldValue,
                        history.NewValue,
                        history.UpdatedBy,
                        history.Updated
                    });
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
            string query = "DeleteHistories @ID";
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

        public List<HistoryDTO> GetAll()
        {
            string query = "GetHistories";
            List<HistoryDTO> result = new List<HistoryDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<HistoryDTO>(query).AsList<HistoryDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public HistoryDTO GetByID(int id)
        {
            string query = "GetHistoriesByID @ID";
            HistoryDTO result = new HistoryDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<HistoryDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public HistoryDTO GetByTable(string table)
        {
            string query = "GetCityByName @Table";
            HistoryDTO result = new HistoryDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<HistoryDTO>(query, new { table });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public HistoryDTO GetByUpdated(DateTime updated)
        {
            string query = "GetCityByUpdated @Updated";
            HistoryDTO result = new HistoryDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<HistoryDTO>(query, new { updated });
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

