using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL
{
    public static class DBConfigurator
    {
        private static string _connectionString = @"Server=(LocalDB)\MSSQLLocalDB;Database = TestDB 7;Integrated Security=true;";
        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }
    }
}
