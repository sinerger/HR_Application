using AutoMapper;
using HR_Application_BLL.Mappers;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class BaseMapper
    {
        protected Mapper _mapper;

        public BaseMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CustomMapperProfile>();
            });

            _mapper = new Mapper(config);
        }
    }
}
