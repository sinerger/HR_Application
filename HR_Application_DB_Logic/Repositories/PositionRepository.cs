using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Dapper;

namespace HR_Application_DB_Logic.Repositories
{
    public class PositionRepository
    {
        public bool Insert(PositionDTO position)
        {
            throw new NotImplementedException();
        }

        public bool Update(PositionDTO position)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int positionId)
        {
            throw new NotImplementedException();
        }

        public PositionDTO GetByTitle(string positionTitle)
        {
            string query = "GetPositionByTitle";
            PositionDTO result = new PositionDTO();

            using (IDbConnection dbConnection = new SqlConnection(AppConnection.ConnectionString))
            {
                result = dbConnection.QuerySingle<PositionDTO>(query, new { Title = positionTitle });
            }

            return result;
        }

        public List<PositionDTO> GetAll()
        {
            string query = "crud_PositionsRead";
            List<PositionDTO> result = new List<PositionDTO>();

            using (IDbConnection dbConnection = new SqlConnection(AppConnection.ConnectionString))
            {
                result = dbConnection.Query<PositionDTO>(query, commandType: CommandType.StoredProcedure).AsList<PositionDTO>();
            }

            return result;
        }

        public PositionDTO GetPositionById(int positionId)
        {
            string query = "GetPositionByID";
            PositionDTO result = new PositionDTO();

            using (IDbConnection dbConnection = new SqlConnection(AppConnection.ConnectionString))
            {
                result = dbConnection.QuerySingle<PositionDTO>(query, new { ID = positionId });

            }

            return result;
        }
    }
}
