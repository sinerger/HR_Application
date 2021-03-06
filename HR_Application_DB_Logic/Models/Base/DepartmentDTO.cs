namespace HR_Application_DB_Logic.Models
{
    public class DepartmentDTO
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is DepartmentDTO)
            {
                DepartmentDTO department = (DepartmentDTO)obj;

                if (department.ID == ID
                    && department.Title == Title
                    && department.Description == Description
                   )
                {
                    result = true;
                }
            }

            return result;
        }

        public override string ToString()
        {
            return $"{Title} d.{Description}";
        }
    }
}
