using AutoMapper;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class BaseMapper<T, J>
    {
        protected Mapper _mapper;
        public IDBController DBController { get; private set; }

        public virtual List<T> GetAllModelsFromDTO()
        {
            throw new NotImplementedException();
        }

        public virtual J GetDTOFromModel(T model)
        {
            throw new NotImplementedException();
        }

        public BaseMapper(IDBController dbController)
        {
            DBController = dbController;

            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CustomMapperProfile>();
            });

            _mapper = new Mapper(config);
        }
    }
}
