using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Services;
using HR_Application_DB_Logic;
using HR_Application_DB_Logic.Interfaces;

namespace HR_Application_DB_WPF.Classes
{
    public class Loader
    {
        private Cache _cache;
        private IDBController _dbController;

        public Loader()
        {
            _cache = Cache.GetCache();
            _dbController = new DBController(DBConfigurator.ConnectionString);
        }

        public void UpdateEmployees()
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

        public void UpdateCompanies()
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

        public void LoadAllData()
        {
            LoadAllCompanies();
            LoadAllDepartments();
            LoadAllUsers();
            LoadAllEmployees();
            LoadAllPositionsModels();
            LoadAllLevelsPosition();
            LoadAllSkills();
            LoadAllLevelSkills();
            LoadAllDepartments();
            LoadAllCities();
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

        public void CreateCompany(Company company)
        {
            try
            {
                company.ID = new CompanyService(_dbController).Create(company);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                new EmployeeService(_dbController).Update(employee);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void LoadAllCities()
        {
            try
            {
                _cache.Cities = new CityMapper().GetModelsFromDTO(_dbController.CityRepository.GetAll());
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void LoadAllSkills()
        {
            try
            {
                _cache.Skills = new SkillModelMapper().GetModelsFromDTO(_dbController.SkillRepository.GetAll());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void LoadAllLevelSkills()
        {
            try
            {
                _cache.LevelsSkills = new LevelSkillModelMapper().GetModelsFromDTO(_dbController.LevelSkillRepository.GetAll());
            }
            catch (Exception e)
            {
                throw e;
            }
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

        private void LoadAllDepartments()
        {
            try
            {
                _cache.Departments = new DepartmentService(_dbController).GetAll();
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
