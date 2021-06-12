using HR_Application_BLL.Models.Base;
using System.Linq;
using System.Collections.Generic;

namespace HR_Application_BLL.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<ProjectModel> Projects { get; set; }

        public Department()
        {
            Projects = new List<ProjectModel>();
        }

        public Department Clone()
        {
            return new Department()
            {
                ID = ID,
                Title = Title,
                Description = Description,
                Projects = new List<ProjectModel>(Projects.Select(project => project.Clone()))
            };
        }

        public override string ToString()
        {
            return $"Department title: {Title}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Department)
            {
                Department department = (Department)obj;

                if (department.ID == ID
                    && department.Title == Title
                    && department.Description == Description
                    && department.Projects.SequenceEqual(Projects))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
