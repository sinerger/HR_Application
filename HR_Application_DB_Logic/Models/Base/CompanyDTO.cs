namespace HR_Application_DB_Logic.Models
{
    public class CompanyDTO
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public int? LocationID { get; set; }
        public string Description { get; set; }
        public bool? IsActual { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
