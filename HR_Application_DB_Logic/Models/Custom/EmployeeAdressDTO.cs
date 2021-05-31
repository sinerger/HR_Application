namespace HR_Application_DB_Logic.Models
{
     public class EmployeeAdressDTO
    {
        public int? ID { get; set; }
        public string Photo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegistationDate { get; set; }
        public StatusDTO Status { get; set; }
        public AdressDTO Adress { get; set; }
        public bool? IsActual { get; set; }
    }
}
