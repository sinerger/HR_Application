namespace HR_Application_DB_Logic.Models
{
    public class CountryDTO
    {
        public int? ID { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if(obj is CountryDTO)
            {
                CountryDTO countryDTO = (CountryDTO)obj;

                if(countryDTO.ID== ID&& countryDTO.Name == Name)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}