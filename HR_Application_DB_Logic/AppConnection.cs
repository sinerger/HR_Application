using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace HR_Application_DB_Logic
{
    public static class AppConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    }
}
