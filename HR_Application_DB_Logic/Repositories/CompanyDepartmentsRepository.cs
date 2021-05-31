using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_DB_Logic.Models.Custom;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using HR_Application_DB_Logic.Models;

namespace HR_Application_DB_Logic.Repositories
{
    public class CompanyDepartmentsRepository
    {
        private string _connectionString;

        public CompanyDepartmentsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
