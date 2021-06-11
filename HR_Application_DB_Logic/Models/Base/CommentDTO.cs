namespace HR_Application_DB_Logic.Models
{
    public class CommentDTO
    {
        public int? ID { get; set; }
        public int? EmployeeID { get; set; }
        public string Information { get; set; }
        public string Date { get; set; }

        public override string ToString()
        {
            return $"{Information} d.{Date}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is CommentDTO)
            {
                CommentDTO comment = (CommentDTO)obj;

                if (comment.ID == ID
                    && comment.EmployeeID == EmployeeID
                    && comment.Information == Information
                    && comment.Date == Date)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
