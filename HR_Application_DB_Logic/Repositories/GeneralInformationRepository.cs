using Dapper;
using HR_Application_DB_Logic.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class GeneralInformationRepository
    {
        private string _connectionString;

        public GeneralInformationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public GeneralInformationDTO GetByEmployeeID(int employeeID)
        {
            string query = "GetGeneralInformationByEmployeeID @employeeID";
            GeneralInformationDTO result = new GeneralInformationDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<GeneralInformationDTO>(query, new { employeeID });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public GeneralInformationDTO GetByID(int id)
        {
            string query = "GetGeneralInformationByID @ID";
            GeneralInformationDTO result = new GeneralInformationDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.QuerySingle<GeneralInformationDTO>(query, new { id });
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public List<GeneralInformationDTO> GetAll()
        {
            string query = "GetGeneralInformation";
            List<GeneralInformationDTO> result = new List<GeneralInformationDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    result = dbConnection.Query<GeneralInformationDTO>(query).AsList<GeneralInformationDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool Delete(int id)
        {
            string query = "DeleteGeneralInformation @ID";
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

        public bool Update(GeneralInformationDTO generalInformation)
        {
            string query = "DeleteGeneralInformation @ID @EmployeeID @Sex @Education @FamilyStatusID @Phone @Email @BirthDate @Hobby @AmountChildren";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        generalInformation.ID,
                        generalInformation.EmployeeID,
                        generalInformation.Sex,
                        generalInformation.Education,
                        generalInformation.FamilyStatusID,
                        generalInformation.Phone,
                        generalInformation.Email,
                        generalInformation.BirthDate,
                        generalInformation.Hobby,
                        generalInformation.AmountChildren
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }
        
        public bool Create(GeneralInformationDTO generalInformation)
        {
            string query = "CreateGeneralInformation @ID @EmployeeID @Sex @Education @FamilyStatusID @Phone @Email @BirthDate @Hobby @AmountChildren";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Execute(query, new
                    {
                        generalInformation.ID,
                        generalInformation.EmployeeID,
                        generalInformation.Sex,
                        generalInformation.Education,
                        generalInformation.FamilyStatusID,
                        generalInformation.Phone,
                        generalInformation.Email,
                        generalInformation.BirthDate,
                        generalInformation.Hobby,
                        generalInformation.AmountChildren
                    });
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
