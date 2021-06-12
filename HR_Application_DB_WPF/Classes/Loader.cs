using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL;
using HR_Application_BLL.Mappers.Base;
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
            LoadAllPositionsModels();
            LoadAllLevelsPosition();
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

        private void LoadAllPositionsModels()
        {
            try
            {
                _cache.PositionsModels = new PositionMapper().GetModelsFromDTO(_dbController.PositionRepository.GetAll());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void LoadAllLevelsPosition()
        {
            try
            {
                _cache.levelsPositionModels = new LevelsPositionMapper().GetModelsFromDTO(_dbController.LevelPositionRepository.GetAll());
            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}
