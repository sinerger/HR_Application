using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;

namespace HR_Application_DB_WPF.Classes
{
    public class Cache
    {
        private static Cache _cashe;

        #region Data Region
        public List<User> Users { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Company> Companies { get;  set; }
        public List<Department> Departments { get; set; }
        public ProjectMapper Projects { get; set; }
        public List<PositionModel> PositionsModels { get;  set; }
        public List<LevelsPositionModel> levelsPositionModels { get;  set; }
        public List<SkillModel> Skills { get; set; }
        public List<LevelSkillModel> LevelsSkills { get; set; }
        public List<CityModel> Cities { get; set; }
        #endregion

        public Company SelectedCompany { get; set; }
        public Employee SelectedEmployee { get; set; }
        public Employee SelectedEmployeeCopy { get; set; }
        public User CurrentUser { get; set; }
        public List<Competence> SelectedCompetences { get; set; }
        public Position SelectedPosition { get; set; }
        public ProjectModel SelectedProject { get; set; }

        private Cache()
        {

        }

        public static Cache GetCache()
        {
            if (_cashe == null)
            {
                _cashe = new Cache();
            }

            return _cashe;
        }
    }
}
