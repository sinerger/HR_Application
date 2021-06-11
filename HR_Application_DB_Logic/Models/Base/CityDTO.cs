namespace HR_Application_DB_Logic.Models
{
    public class CityDTO
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public int? CountryID { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is CityDTO)
            {
                CityDTO cityDTO = (CityDTO)obj;

                if (cityDTO.ID == ID
                    && cityDTO.Name == Name
                    && cityDTO.CountryID == CountryID)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}