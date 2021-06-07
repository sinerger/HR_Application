namespace HR_Application_DB_Logic.Models
{
    public class AdressDTO
    {
        public int? ID { get; set; }
        public string Street { get; set; }
        public int? HouseNumber { get; set; }
        public string Block { get; set; }
        public int? ApartmentNumber { get; set; }
        public int? PostIndex { get; set; }
        public CityDTO City { get; set; }
        public CountryDTO Country { get; set; }

        public override bool Equals(object obj)
        {

            bool result = false;

            if (obj is AdressDTO)
            {
                AdressDTO adressDTO = (AdressDTO)obj;
                if (adressDTO.ID == ID
                    && adressDTO.Street == Street
                    && adressDTO.HouseNumber == HouseNumber
                    && adressDTO.Block == Block
                    && adressDTO.ApartmentNumber == ApartmentNumber
                    && adressDTO.PostIndex == PostIndex
                    && adressDTO.City.Equals(City)
                    && adressDTO.Country.Equals(Country))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}