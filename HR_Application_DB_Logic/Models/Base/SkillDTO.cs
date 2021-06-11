namespace HR_Application_DB_Logic.Models
{
    public class SkillDTO
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is SkillDTO)
            {
                SkillDTO skillDTO = (SkillDTO)obj;

                if (skillDTO.ID == ID
                    && skillDTO.Title == Title
                    && skillDTO.Description == Description)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
