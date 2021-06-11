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
                LevelsPositionDTO levelsPositionDTODTO = (LevelsPositionDTO)obj;

                if (levelsPositionDTODTO.ID == ID
                    && levelsPositionDTODTO.Title == Title
                    && levelsPositionDTODTO.Description == Description)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}