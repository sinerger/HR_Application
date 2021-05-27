using HR_Application_DB_Logic.Repositories;
using System.Configuration;

namespace HR_Application_DB_Logic.DBController
{
    public class DBController
    {
        private string _connectionString = @"Server=(LocalDB)\MSSQLLocalDB; DataBase = NewEmployeesDB; Trusted_Connection = True; Integrated Security = True;";
        private static DBController _dbController;

        public EmployeeRepository EmployeeRepository { get; private set; }

        private DBController ()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["HRApplicationDB"].ConnectionString;
            EmployeeRepository = new EmployeeRepository(_connectionString);
        }

        public static DBController GetController()
        {
            if(_dbController == null)
            {
                _dbController = new DBController();
            }

            return _dbController;
        }

    }
}
