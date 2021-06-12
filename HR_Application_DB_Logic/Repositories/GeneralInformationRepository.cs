using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class GeneralInformationRepository :IRepository<GeneralInformationDTO>
    {
        public string ConnectionString { get; private set; }

        public GeneralInformationRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public GeneralInformationDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetGeneralInformationByID @ID";
            GeneralInformationDTO result = new GeneralInformationDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<GeneralInformationDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public List<GeneralInformationDTO> GetAll()
        {
            string query = "[HRAppDB].GetGeneralInformation";
            List<GeneralInformationDTO> result = new List<GeneralInformationDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<GeneralInformationDTO>(query).AsList<GeneralInformationDTO>();
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
            string query = "[HRAppDB].DeleteGeneralInformation @ID";
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

        public bool Update(GeneralInformationDTO generalInformation)
        {
            string query = "[HRAppDB].DeleteGeneralInformation @ID, @EmployeeID, @Sex, @Education, @FamilyStatusID, @Phone, @Email, @BirthDate, @Hobby, @AmountChildren";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
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
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
        
        public int Create(GeneralInformationDTO generalInformation)
        {
            int returnID = 0;
            string query = "[HRAppDB].CreateGeneralInformation @ID, @EmployeeID, @Sex, @Education, @FamilyStatusID, @Phone, @Email, @BirthDate, @Hobby, @AmountChildren";

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.QuerySingle<int>(query, new
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
            catch (Exception e)
            {
                throw e;
            }

            return returnID;
        }
    }
}
