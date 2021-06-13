namespace HR_Application_DB_Logic.Models
{
    public class LocationDTO
    {
        public int? ID { get; set; }
        public int? CityID { get; set; }
        public string Street { get; set; }
        public int? HouseNumber { get; set; }
        public string Block { get; set; }
        public int? ApartmentNumber { get; set; }
        public int? PostIndex { get; set; }

        public LocationDTO()
        {
            Street = " ";
            Block = " ";
            HouseNumber = 0;
            ApartmentNumber = 0;
            PostIndex = 0;
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is LocationDTO)
            {
                LocationDTO location = (LocationDTO)obj;

                if (location.ID == ID
                    && location.CityID == CityID
                    && location.Street == Street
                    && location.HouseNumber == HouseNumber
                    && location.Block == Block
                    && location.ApartmentNumber == ApartmentNumber
                    && location.PostIndex == PostIndex)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
