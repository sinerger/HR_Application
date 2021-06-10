using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
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

                List<Company> companies = _companyMapper.GetModelsFromDTO(companiesDTO);

                foreach (Company company in companies)
                {
                    var adressID = companiesDTO.Find(comp => comp.ID == company.ID).ID;
                    company.Adress = adresses.Find(adress => adress.ID == adressID);

                    //company.Departments = departments.Select(dep=>dep).Where(dep=>dep.)

                    return null;
                }

                return null;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
