using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeeSkillRepository : IRepository<EmployeeSkillDTO>
    {
        public string ConnectionString { get; private set; }

        public EmployeeSkillRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool Create(EmployeeSkillDTO employeeSkill)
        {
            string query = @"[HRAppDB].CreateEmployeeSkill @EmployeeID, @Date, 
                @IsActual, @UserID, @LevelSkillID, @SkillID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { 
                        employeeSkill.EmployeeID,
                        employeeSkill.Date,
                        employeeSkill.IsActual,
                        employeeSkill.UserID,
                        employeeSkill.LevelSkillID,
                        employeeSkill.SkillID
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
            string query = "[HRAppDB].DeleteEmployeeSkill @ID";
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

        public List<EmployeeSkillDTO> GetAll()
        {
            string query = "[HRAppDB].GetEmployeeSkill";
            List<EmployeeSkillDTO> result = new List<EmployeeSkillDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<EmployeeSkillDTO>(query).AsList<EmployeeSkillDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public EmployeeSkillDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetEmployeeSkillByEmployeeID @ID";
            EmployeeSkillDTO result = new EmployeeSkillDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<EmployeeSkillDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Update(EmployeeSkillDTO employeeSkill)
        {
            string query = @"[HRAppDB].UpdateEmployeeSkill @ID, @EmployeeID, @Date, 
                @IsActual, @UserID, @LevelSkillID, @SkillID";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new {
                        employeeSkill.ID,
                        employeeSkill.EmployeeID,
                        employeeSkill.Date,
                        employeeSkill.IsActual,
                        employeeSkill.UserID,
                        employeeSkill.LevelSkillID,
                        employeeSkill.SkillID
                    });
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
