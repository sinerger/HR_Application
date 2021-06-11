namespace HR_Application_DB_Logic.Models
{
    public class PositionDTO
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Title: {Title} Description: {Description}";
        }
        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is PositionDTO)
            {
                PositionDTO position = (PositionDTO)obj;

                if (position.ID == ID
                    && position.Title == Title
                    && position.Description == Description)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
