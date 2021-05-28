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
    public class PositionRepository : IPositionRepository
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

        public List<PositionDTO> GetPositionByTitle(string positionTitle)
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "GetPositionByTitle";
            if (db.State == ConnectionState.Closed)
                db.Open();
            return db.Query<PositionDTO>(query, new { Title = positionTitle }, commandType: CommandType.StoredProcedure).AsList<PositionDTO>();
        }

        public List<PositionDTO> GetPositions()
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "crud_PositionsRead";
            if (db.State == ConnectionState.Closed)
                db.Open();
            return db.Query<PositionDTO>(query, commandType: CommandType.StoredProcedure).AsList<PositionDTO>();
        }

        public List<PositionDTO> GetPositionById(int positionId)
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "GetPositionByID";
            if (db.State == ConnectionState.Closed)
                db.Open();
            return db.Query<PositionDTO>(query, new { ID = positionId }, commandType: CommandType.StoredProcedure).AsList<PositionDTO>();
        }
    }
}
