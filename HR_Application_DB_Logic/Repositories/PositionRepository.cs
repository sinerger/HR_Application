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

        public IEnumerable<PositionDTO> GetPositions()
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            if (db.State == ConnectionState.Closed)
                db.Open();
            return db.Query<PositionDTO>("exec crudPositionsRead", commandType: CommandType.Text);
        }

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
    }
}
