using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using System;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeePositionRepository : IRepository<EmployeePositionDTO>
    {
        public string ConnectionString { get; private set; }

        public EmployeePositionRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<EmployeePositionDTO> GetAll()
        {
            string query = "[HRAppDB].[GetEmployeesPositions]";

            List<EmployeePositionDTO> result = new List<EmployeePositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<EmployeePositionDTO>(query).AsList<EmployeePositionDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public EmployeePositionDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetEmployeePositionByID @ID";
            EmployeePositionDTO employeePosition = null;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    employeePosition = dbConnection.QuerySingle<EmployeePositionDTO>(query, new { id });                 
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return employeePosition;
        }

        public bool Update(EmployeePositionDTO obj)
        {
            string query = "[HRAppDB].[UpdateEmployeePosition] @ID, @EmployeeID, @PositionID," +
                "@HiredDate, @FiredDate, @IsActual, @LevelPosition";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { obj.ID, obj.EmployeeID, obj.PositionID, obj.HiredDate,
                    obj.FiredDate, obj.IsActual, obj.LevelPosition});
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
            string query = "[HRAppDB].[DeleteEmployeePosition] @ID";
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

        public int Create(EmployeePositionDTO obj)
        {
            string query = "[HRAppDB].[CreateEmployeePosition] @EmployeeID, @PositionID," +
                "@HiredDate, @FiredDate, @IsActual, @LevelPosition";
            bool result = true;

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Execute(query, new { obj.EmployeeID, obj.PositionID,
                        obj.HiredDate, obj.FiredDate, obj.IsActual, obj.LevelPosition });
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