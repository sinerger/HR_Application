using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAllDTO();
        T GetDTOByID(int id);
        int Create(T obj);
        void Update(T obj);
        bool Delete(int id);
    }
}
