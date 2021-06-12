namespace HR_Application_DB_Logic.Models
{
    public class LevelsPositionDTO
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Title:{Title} Description:{Description}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is LevelsPositionDTO)
            {
                LevelsPositionDTO levelsPositionDTO = (LevelsPositionDTO)obj;

                if (levelsPositionDTO.ID == ID
                    && levelsPositionDTO.Title == Title
                    && levelsPositionDTO.Description == Description)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}