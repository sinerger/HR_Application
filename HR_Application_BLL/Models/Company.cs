﻿using HR_Application_BLL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Desctiption { get; set; }
        public Adress Adress { get; set; }
        public List<DepartmentModel> Departments { get; set; }

        public override string ToString()
        {
            return $"{Title} Count departmetns: {Departments.Count}";
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
                    && company.Departments == Departments)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}