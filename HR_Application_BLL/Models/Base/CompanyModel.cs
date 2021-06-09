namespace HR_Application_BLL.Models.Base
{
    public class CompanyModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int LocationID { get; set; }
        public string Description { get; set; }
        public bool IsActual { get; set; }

        public override string ToString()
        {
            return $"Title: {Title} Description: {Description}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is CompanyModel)
            {
                CompanyModel companyModel = (CompanyModel)obj;

                if (companyModel.ID == ID
                    && companyModel.Title == Title
                    && companyModel.LocationID == LocationID
                    && companyModel.Description == Description
                    && companyModel.IsActual == IsActual)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}