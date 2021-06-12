namespace HR_Application_BLL.Models.Base
{
    public class ProjectModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DirectionID { get; set; }

        public ProjectModel Clone()
        {
            return new ProjectModel()
            {
                ID = ID,
                Title = Title,
                Description = Description,
                DirectionID = DirectionID
            };
        }

        public override string ToString()
        {
            return $"Project title:{Title}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is ProjectModel)
            {
                ProjectModel project = (ProjectModel)obj;

                if (project.ID == ID
                    && project.Title == Title
                    && project.Description == Description
                    && project.DirectionID == DirectionID)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}