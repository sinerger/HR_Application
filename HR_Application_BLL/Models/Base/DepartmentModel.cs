namespace HR_Application_BLL.Models.Base
{
    public class DepartmentModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is DepartmentModel)
            {
                DepartmentModel department = (DepartmentModel)obj;

                if (department.ID == ID 
                    && department.Title == Title 
                    && department.Description == Description)
                {
                    result = true;
                }
            }

            return result;
        }

        public override string ToString()
        {
            return $"Department title: {Title}";
        }
    }
}
