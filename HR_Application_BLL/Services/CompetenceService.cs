using HR_Application_BLL.Mappers;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using HR_Application_DB_Logic.Models.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Services
{
    public class CompetenceService
    {
        private IDBController _dbController;
        private CompetenceMapper _competenceMapper;

        public CompetenceService(IDBController dbController)
        {
            _dbController = dbController;
            _competenceMapper = new CompetenceMapper();
        }

        public List<Competence> GetAll()
        {
            try
            {
                List<EmployeeSkillDTO> employeeSkillsDTO = _dbController.EmployeeSkillRepository.GetAll();
                List<SkillModel> skills = new SkillModelMapper()
                    .GetModelsFromDTO(_dbController.SkillRepository.GetAll());
                List<LevelSkillModel> levelSkillsModel = new LevelSkillModelMapper()
                    .GetModelsFromDTO(_dbController.LevelSkillRepository.GetAll());
                List<Competence> competences = new CompetenceMapper()
                    .GetCompetencesFromDTO(employeeSkillsDTO);

                foreach (Competence competence in competences)
                {
                    var employeeSkillDTO = employeeSkillsDTO.Find(employeeSkillDTO => employeeSkillDTO.EmployeeID == competence.EmployeeID);
                    employeeSkillsDTO.Remove(employeeSkillDTO);

                    competence.Skill = skills.Find(skill => skill.ID == employeeSkillDTO.SkillID);
                    competence.LevelSkill = levelSkillsModel.Find(level => level.ID == employeeSkillDTO.LevelSkillID);
                }

                return competences;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Competence GetByID(int id)
        {
            try
            {
                EmployeeSkillDTO employeeSkillDTO = _dbController.EmployeeSkillRepository.GetByID(id);
                SkillModel skill = new SkillModelMapper()
                    .GetModelFromDTO(_dbController.SkillRepository.GetByID((int)employeeSkillDTO.LevelSkillID));
                LevelSkillModel levelSkill = new LevelSkillModelMapper()
                    .GetModelFromDTO(_dbController.LevelSkillRepository.GetByID((int)employeeSkillDTO.LevelSkillID));

                Competence competence = new CompetenceMapper().GetCompetenceFromDTO(employeeSkillDTO);
                competence.Skill = skill;
                competence.LevelSkill = levelSkill;

                return competence;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
