namespace HR_Application_DB_Logic.Models
{
    public class LevelSkillDTO
    {
        public int? ID { get; set; }
        public string Title { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is LevelSkillDTO)
            {
                LevelSkillDTO levelSkillDTO = (LevelSkillDTO)obj;

                if (levelSkillDTO.ID == ID
                    && levelSkillDTO.Title == Title)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
