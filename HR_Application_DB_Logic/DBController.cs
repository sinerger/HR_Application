using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HR_Application_DB_Logic.Models;
using NUnit.Framework;
using HR_Application_DB_Logic.Repositories;

namespace HR_Application_DB_Logic
{
    
    public class DBController
    {
        private string _connectionString;

        public SkillRepository SkillRepository
        {
            get
            {
                return new SkillRepository(_connectionString);
            }
        }

        public LevelSkillRepository LevelSkillRepository
        {
            get
            {
                return new LevelSkillRepository(_connectionString);
            }
        }

        public EmployeeSkillRepository EmployeeSkillRepository
        {
            get
            {
                return new EmployeeSkillRepository(_connectionString);
            }
        }

        public DBController(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
