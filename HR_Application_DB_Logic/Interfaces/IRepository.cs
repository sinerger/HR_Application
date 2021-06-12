using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Interfaces
{
    public interface IRepository<T>
    {
        string ConnectionString { get; }
        List<T> GetAll();
        T GetByID(int id);
        bool Update(T obj);
        bool Delete(int id);
        int Create(T obj);
    }
}
