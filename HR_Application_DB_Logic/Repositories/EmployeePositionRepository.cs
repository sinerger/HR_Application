﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;

namespace HR_Application_DB_Logic.Repositories
{
    public class EmployeePositionRepository : IRepository<EmployeePositionDTO>
    {
        public string ConnectionString { get; }

        public EmployeePositionRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<EmployeePositionDTO> GetAll()
        {
            string query = "[HRAppDB].GetEmployeesPosition";
            List<EmployeePositionDTO> result = new List<EmployeePositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<EmployeePositionDTO, int, int, EmployeePositionDTO>(query,
                        (ep, levelPos, position) =>
                        {
                            ep.LevelPositionID = levelPos;
                            ep.PositionID = position;
                            return ep;
                        })
                        .AsList<EmployeePositionDTO>();
                }
            }
            catch 
            {
                result = null;
            }

            return result;
        }
        public List<EmployeePositionDTO> GetByEmployeeID(int employeeID)
        {
            string query = "[HRAppDB].GetEmployeesPositionByEmployeeID @EmployeeID";
            List<EmployeePositionDTO> result = new List<EmployeePositionDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<EmployeePositionDTO, int, int, EmployeePositionDTO>(query,
                        (ep, levelPos, position) =>
                        {
                            ep.LevelPositionID = levelPos;
                            ep.PositionID = position;
                            return ep;
                        },new { employeeID })
                        .AsList<EmployeePositionDTO>();
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public EmployeePositionDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(EmployeePositionDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create(EmployeePositionDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
