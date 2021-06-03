using HR_Application_BLL.Models;
using HR_Application_DB_Logic;
using HR_Application_DB_Logic.Models.Custom;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace HR_Application_BLL.Controllers
{
    public class CompetenceController
    {
        private DBController _dbController;
        private MapperConfiguration _mapperConfig;
        private Mapper _mapper;


        public CompetenceController()
        {
            _dbController = new DBController(DBConfigurator.ConnectionString);

            _mapperConfig = new MapperConfiguration(config => config.CreateMap<EmployeeSkillDTO, Competence>()
                .ForMember(dest => dest.Level, option => option
                    .MapFrom(sourse => _dbController.LevelSkillRepository.GetByID(sourse.LevelID).Title))
                .ForMember(dest => dest.Name, option => option
                    .MapFrom(sourse => _dbController.SkillRepository.GetByID(sourse.SkillID).Title))
                .ForMember(dest=> dest.Date, option =>option.MapFrom(source=>source.Date)));

            _mapper = new Mapper(_mapperConfig);
        }

        public List<Competence> GetCompetencesByEmployeeID(int employeeID)
        {
            List<EmployeeSkillDTO> skills = _dbController.EmployeeSkillRepository.GetAllByEmployeeID(employeeID);
            var result = new List<Competence>();

            if (skills != null)
            {
                result = _mapper.Map<List<Competence>>(skills);
            }

            return result;
        }
    }
}
