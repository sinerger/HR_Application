using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL
{
    public static class DBConfigurator
    {
        //private static string _connectionString = @"Server = 80.78.240.16; Database = Sandbox.Test; User Id = devEd; Password = qqq!11;";
        private static string _connectionString = @"Server = 80.78.240.16; Database = Sandbox; User Id = devEd; Password = qqq!11;";
        //private static string _connectionString =
        //    @"Server=(LocalDB)\MSSQLLocalDB;Database =test data 4;Integrated Security=true;";
        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }
    }
}
