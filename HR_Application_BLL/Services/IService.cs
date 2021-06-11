using HR_Application_DB_Logic.Interfaces;
using System.Collections.Generic;

namespace HR_Application_BLL.Services
{
    public interface IService<T>
    {
        public List<T> GetAll();
        public T GetByID(int id);
    }
}