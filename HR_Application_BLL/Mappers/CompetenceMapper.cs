using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_DB_Logic.Models.Custom;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers
{
    public class CompetenceMapper: BaseMapper
    {
        public List<Competence> GetCompetencesFromDTO(List<EmployeeSkillDTO> employeeSkillsDTO)
        {
            if (employeeSkillsDTO != null)
            {
                return _mapper.Map<List<Competence>>(employeeSkillsDTO); 
            }
           
                throw new ArgumentNullException("List EmployeeSkillsDTO is null");
        }

        public Competence GetCompetenceFromDTO(EmployeeSkillDTO employeeSkillsDTO)
        {
            if (employeeSkillsDTO != null)
            {
                return _mapper.Map<Competence>(employeeSkillsDTO);
            }

                throw new ArgumentNullException("EmployeeSkillDTO is null"); 
        }

        public EmployeeSkillDTO GetDTOFromCompetence(Competence competence)
        {
            if (competence != null)
            {
                return _mapper.Map<EmployeeSkillDTO>(competence);
            }

            throw new ArgumentNullException("Competence is null");
        }
    }
}
