using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;

namespace HR_Application_DB_WPF.Classes
{
    public class Cache
    {
        private static Cache _cashe;

        public List<User> Users { get; set; }
        public List<Company> Companies { get; set; }
        public Company SelectedCompany { get; set; }
        public Employee SelectedEmployee { get; set; }
        public User CurrentUser { get; set; }
        public List<Employee> Employees { get; set; }

        public Position SelectedPositionEmployee { get; set; }

        private Cache()
        {

        }

        public static Cache GetCache()
        {
            if (_cashe == null)
            {
                _cashe = new Cache();
            }

            return _cashe;
        }
    }
}
