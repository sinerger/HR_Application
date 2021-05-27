using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class CityRepository : ICityRepository
    {
        public IEnumerable<CityDTO> GetCities()
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            return db.Query<CityDTO>("exec crud_CitiesRead", commandType: CommandType.Text);
        }
        public bool Insert(CityDTO city)
        {
            throw new NotImplementedException();
        }
        public bool Update(CityDTO city)
        {
            throw new NotImplementedException();
        }
        public bool Delete(string cityId)
        {
            throw new NotImplementedException();
        }
    }
}
