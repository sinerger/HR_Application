using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL;
using HR_Application_BLL.Models;
using HR_Application_BLL.Services;
using HR_Application_DB_Logic;

namespace HR_Application_DB_WPF.Classes
{
    public class Loader
    {
        private Cache _cache;
        private DBController _dbController;

        public Loader()
        {
            _cache = Cache.GetCache();
            _dbController = new DBController(DBConfigurator.ConnectionString);
        }

        public void LoadAllData()
        {
            LoadAllCompanies();
            LoadAllUsers();
            LoadAllEmployees();
        }

        private void LoadAllCompanies()
        {
            try
            {
                _cache.Companies = new CompanyService(_dbController).GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void LoadAllUsers()
        {
            try
            {
                _cache.Users = new UserService(_dbController).GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void LoadAllEmployees()
        {
            try
            {
                _cache.Employees = new EmployeeService(_dbController).GetAll();
            }

            catch (Exception e)
            {

                throw e;
            }
        }

        public void CreateEmployee(Employee employee)
        {
            try
            {
                employee.ID = new EmployeeService(_dbController).Create(employee);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
