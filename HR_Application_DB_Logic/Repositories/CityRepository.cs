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
        public List<CityDTO> GetCities()
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "crud_CitiesRead";
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            return db.Query<CityDTO>(query, commandType: CommandType.StoredProcedure).AsList<CityDTO>();
        }
        public bool Insert(CityDTO city)
        {
            throw new NotImplementedException();
        }
        public bool Update(CityDTO city)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int cityId)
        {
            throw new NotImplementedException();
        }

        public List<CityDTO> GetCityByID(int id)
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "GetCityByID";
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            return db.Query<CityDTO>(query, new { ID = id }, commandType: CommandType.StoredProcedure).AsList<CityDTO>();
        }

        public List<CityDTO> GetCityByName(string Name)
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            string query = "GetCityByName";
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            return db.Query<CityDTO>(query, new { Name = Name }, commandType: CommandType.StoredProcedure).AsList<CityDTO>();
        }
    }
}
