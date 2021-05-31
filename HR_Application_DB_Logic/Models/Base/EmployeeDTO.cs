﻿namespace HR_Application_DB_Logic.Models
{
    public class EmployeeDTO
    {
        public int ID { get; set; }
        public string Photo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegistrationDate { get; set; }
        public int StatusID { get; set; }
        public int LocationID { get; set; }
        public bool IsActual { get; set; }
    }
}
