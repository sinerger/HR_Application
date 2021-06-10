using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR_Application_BLL.Services
{
    public class CompanyService
    {
        private IDBController _dbController;
        private CompanyMapper _companyMapper;

        public CompanyService(IDBController dbController)
        {
            _dbController = dbController;
            _companyMapper = new CompanyMapper();
        }

        public List<Company> GetAll()
        {
            try
            {
                List<CompanyDTO> companiesDTO = _dbController.CompanyRepository.GetAll();
                List<Adress> adresses = new AdressService(_dbController).GetAll();
                List<Department> departments = new DepartmentService(_dbController).GetAll();
                List<CompanyDepartmentsDTO> companiesDepartmentsDTO = _dbController.CompanyDepartmentsRepository.GetAll();
                List<Company> companies = _companyMapper.GetModelsFromDTO(companiesDTO);

                foreach (Company company in companies)
                {
                    int adressID = (int)companiesDTO.Find(comp => comp.ID == company.ID).ID;
                    company.Adress = adresses.Find(adress => adress.ID == adressID);
                    var companyDepartments = companiesDepartmentsDTO.Find(compDep => compDep.CompanyID == company.ID);

                    if (companyDepartments != null)
                    {
                        company.Departments = new List<Department>(departments.Select(dep => dep)
                            .Where(dep => companyDepartments.DepartmentsID.Contains(dep.ID)));
                    }
                }

                return companies;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Company GetByID(int id)
        {
            try
            {
                CompanyDTO companyDTO = _dbController.CompanyRepository.GetByID(id);
                Company company = _companyMapper.GetCompanyFromDTO(companyDTO);
                company.Adress = new AdressService(_dbController).GetByID((int)companyDTO.LocationID);
                CompanyDepartmentsDTO companyDepartmentsDTO = _dbController.CompanyDepartmentsRepository.GetByID(company.ID);
                if (companyDepartmentsDTO != null)
                {
                    List<Department> departments = new DepartmentService(_dbController).GetAll();
                    company.Departments = new List<Department>(departments.Select(dep => dep)
                        .Where(dep => companyDepartmentsDTO.DepartmentsID.Contains(dep.ID)));
                }
                else
                {
                    company.Departments = new List<Department>();
                }
                return company;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
