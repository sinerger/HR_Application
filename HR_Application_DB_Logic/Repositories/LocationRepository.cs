using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;

namespace HR_Application_DB_Logic.Repositories
{
    public class LocationRepository
    {
        private string _connectionString;

        public LocationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<LocationDTO> GetAll()
        {
            string query = "GetLocations";
            List<LocationDTO> result = new List<LocationDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<LocationDTO>(query).AsList<LocationDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Create(LocationDTO Location)
        {
            string query = "CreateLocation @CityID @Street @HouseNumber @Block @ApartmentNumber @PostIndex";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    { 
                        Location.CityID,
                        Location.Street,
                        Location.HourseNumber,
                        Location.Block,
                        Location.ApartmentNumber,
                        Location.PostIndex
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Update(LocationDTO Location)
        {
            string query = "UpdateLocation @ID @CityID @Street @HouseNumber @Block @ApartmentNumber @PostIndex";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        Location.ID,
                        Location.CityID,
                        Location.Street,
                        Location.HourseNumber,
                        Location.Block,
                        Location.ApartmentNumber,
                        Location.PostIndex
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
            string query = "DeleteLocation @ID";
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

        public LocationDTO GetByID(int id)
        {
            string query = "GetLocationsByID @ID";
            LocationDTO result = new LocationDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<LocationDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public LocationDTO GetByStreet(string Name)
        {
            string query = "GetLocationsByStreet @Street";
            LocationDTO result = new LocationDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<LocationDTO>(query, new { Name });
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
