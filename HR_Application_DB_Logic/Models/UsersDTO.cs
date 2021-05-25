﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models
{
    public class UsersDTO
    {
        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? CompanyID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActual { get; set; }
    }
}
