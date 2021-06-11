using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Interfaces;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class PositionRepository : IRepository<PositionDTO>
    {
        public string ConnectionString { get; private set; }

        public PositionRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public PositionDTO GetByTitle(string title)
        {
            string query = "GetPositionByTitle @Title";
            PositionDTO result = new PositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<PositionDTO>(query, new { title });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public List<PositionDTO> GetAll()
        {
            string query = "GetPositions";
            List<PositionDTO> result = new List<PositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<PositionDTO>(query).AsList<PositionDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public PositionDTO GetById(int id)
        {
            string query = "GetPositionByID @ID";
            PositionDTO result = new PositionDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<PositionDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Create(PositionDTO position)
        {
            string query = "CreatePosition @Title, @Description";
            bool result = true;

            try
            {
                using(IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        position.Title,
                        position.Description
                    });
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public bool Update(PositionDTO position)
        {
            string query = "CreatePosition @ID, @Title, @Description";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        position.ID,
                        position.Title,
                        position.Description
                    });
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public bool Delete(int id)
        {
            string query = "DeletePosition @ID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { id });
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public PositionDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
