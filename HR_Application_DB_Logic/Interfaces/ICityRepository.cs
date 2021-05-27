using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Interfaces
{
    public interface ICityRepository
    {
        IEnumerable<CityDTO> GetCities();
        bool Insert(CityDTO city);
        bool Update(CityDTO city);
        bool Delete(int cityId);
    }
}
