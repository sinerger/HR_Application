namespace HR_Application_DB_Logic.Models
{
    public class CompanyDTO
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public int? LocationID { get; set; }
        public string Description { get; set; }
        public bool? IsActual { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if(obj is CompanyDTO)
            {
                CompanyDTO companyDTO = (CompanyDTO)obj;
                if(companyDTO.ID == ID
                    && companyDTO.Title == Title
                    && companyDTO.LocationID == LocationID
                    && companyDTO.Description == Description
                    && companyDTO.IsActual == IsActual)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
