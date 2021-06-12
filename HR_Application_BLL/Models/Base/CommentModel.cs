using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models.Base
{
    public class CommentModel
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string Information { get; set; }
        public string Date { get; set; }

        public CommentModel Clone()
        {
            return new CommentModel()
            {
                ID = ID,
                EmployeeID = ID,
                Information = Information,
                Date = Date
            };
        }

        public override string ToString()
        {
            return $"{Information} - {Date}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is CommentModel)
            {
                CommentModel comment = (CommentModel)obj;

                if (comment.ID == ID
                    && comment.EmployeeID== EmployeeID
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
