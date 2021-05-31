using Dapper;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class GeneralInformationFamilyStatusRepository
    {
        private string _connectionString;

        public GeneralInformationFamilyStatusRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<GeneralInformationFamilyStatusDTO> GetAll()
        {
            string query = "[HRAppDB].GeneralInformationFamilyStatuses";
            List<GeneralInformationFamilyStatusDTO> result = new List<GeneralInformationFamilyStatusDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<GeneralInformationFamilyStatusDTO, FamilyStatusDTO, GeneralInformationFamilyStatusDTO>
                        (query,
                        (generalInformationFamilyStatus, familyStatus) =>
                        {
                            generalInformationFamilyStatus.FamilyStatus = familyStatus;

                            return generalInformationFamilyStatus;
                        }, splitOn: "ID, IDFamilyStatuses")
                        .AsList<GeneralInformationFamilyStatusDTO>();
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