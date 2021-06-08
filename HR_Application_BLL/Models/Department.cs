using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Department)
            {
                Department department = (Department)obj;

                if (department.ID == ID && department.Title == Title && department.Description == Description)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
