namespace HR_Application_BLL.Models.Base
{
    public class ProjectModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DirectionID { get; set; }

        public override string ToString()
        {
            return $"Title:{Title} Description:{Description}";
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