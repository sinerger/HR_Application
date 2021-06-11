namespace HR_Application_DB_Logic.Models
{
    public class ProjectDTO
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? DirectionID { get; set; }

        public override string ToString()
        {
            return $"Title:{Title} Description:{Description}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is ProjectDTO)
            {
                ProjectDTO project = (ProjectDTO)obj;

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