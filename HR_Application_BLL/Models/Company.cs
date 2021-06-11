﻿using HR_Application_BLL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR_Application_BLL.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Desctiption { get; set; }
        public Adress Adress { get; set; }
        public List<Department> Departments { get; set; }


        public Company()
        {
            Adress = new Adress();
            Departments = new List<Department>();
        }

        public override string ToString()
        {
            return $"{Title}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Company)
            {
                Company company = (Company)obj;

                if (company.ID == ID
                    && company.Title == Title
                    && company.Desctiption == Desctiption
                    && company.Adress.Equals(Adress)
                    && company.Departments.SequenceEqual(Departments))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
