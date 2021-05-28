using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models
{
    public class CommentDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public string Information { get; set; }
        public DateTime? Date { get; set; }
    }
}
