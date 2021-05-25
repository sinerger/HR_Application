using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_DB_Logic.Models
{
    public class HistoriesDTO
    {
        public int? ID { get; set; }
        public string Table { get; set; }
        public string CollumnName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime Updated { get; set; }
    }
}
