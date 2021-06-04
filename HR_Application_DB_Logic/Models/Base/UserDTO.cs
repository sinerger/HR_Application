namespace HR_Application_DB_Logic.Models
{
    public class UserDTO
    {
        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsActual { get; set; }
        public CompanyDTO Company { get; set; }
        public AdressDTO Adress { get; set; }
    }
}
