using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class LocationRepository : IRepository<LocationDTO>
    {
        public string ConnectionString { get; private set; }

        public LocationRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<LocationDTO> GetAll()
        {
            string query = "[HRAppDB].GetLocations";
            List<LocationDTO> result = new List<LocationDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<LocationDTO>(query).AsList<LocationDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public int Create(LocationDTO Location)
        {
            string query = "[HRAppDB].CreateLocation @CityID, @Street, @HouseNumber, @Block, @ApartmentNumber, @PostIndex";
            int returnID = 0;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    returnID = dbConnection.QuerySingle<int>(query, new
                    {
                        Location.CityID,
                        Location.Street,
                        Location.HouseNumber,
                        Location.Block,
                        Location.ApartmentNumber,
                        Location.PostIndex
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }

        public bool Update(LocationDTO Location)
        {
            string query = "[HRAppDB].UpdateLocation @ID, @CityID, @Street, @HouseNumber, @Block, @ApartmentNumber, @PostIndex";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        Location.ID,
                        Location.CityID,
                        Location.Street,
                        Location.HouseNumber,
                        Location.Block,
                        Location.ApartmentNumber,
                        Location.PostIndex
                    });
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
            string query = "[HRAppDB].DeleteLocation @ID";
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

        public LocationDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetLocationsByID @ID";
            LocationDTO result = new LocationDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<LocationDTO>(query, new { id });
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