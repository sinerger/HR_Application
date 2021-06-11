﻿using HR_Application_BLL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HR_Application_BLL.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Photo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegistrationDate { get; set; }
        public int StatusID { get; set; }
        public bool IsActual { get; set; }
        public GeneralInformationModel GeneralInformation { get; set; }
        public PositionModel Position { get; set; }
        public Company Company { get; set; }
        public Adress Adress { get; set; }
        public ProjectModel Project { get; set; }
        public List<Competence> Competence { get; set; }
        public Department Department { get; set; }
        public List<CommentModel> Comments { get; set; }

        public Employee()
        {
            GeneralInformation = new GeneralInformationModel();
            Position = new PositionModel();
            Company = new Company();
            Adress = new Adress();
            Project = new ProjectModel();
            Competence = new List<Competence>();
            Department = new Department();
            Comments = new List<CommentModel>();
        }
        
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Employee)
            {
                Employee employee = (Employee)obj;

                if (employee.ID == ID
                    && employee.FirstName == FirstName
                    && employee.LastName == LastName
                    && employee.RegistrationDate == RegistrationDate
                    && employee.StatusID == StatusID
                    && employee.IsActual == IsActual
                    && employee.GeneralInformation.Equals(GeneralInformation)
                    && employee.Position.Equals(Position)
                    && employee.Company.Equals(Company)
                    && employee.Adress.Equals(Adress)
                    && employee.Project.Equals(Project)
                    && employee.Competence.SequenceEqual(Competence)
                    && employee.Department.Equals(Department)
                    && employee.Comments.SequenceEqual(Comments))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
