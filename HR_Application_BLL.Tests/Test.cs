using System;
using System.Collections.Generic;
using System.Text;
using HR_Application_BLL.Models;
using HR_Application_BLL.Services;
using HR_Application_DB_Logic;
using NUnit.Framework;

namespace HR_Application_BLL.Tests
{
    public class Test
    {
        [Test]
        public void Testas()
        {
            //var a = new EmployeeService(new DBController(DBConfigurator.ConnectionString)).GetAll();
            //var b = new EmployeeService(new DBController(DBConfigurator.ConnectionString)).GetByID(1);
            var d = new CompanyService(new DBController(@"Server=(LocalDB)\MSSQLLocalDB;Database =tesat db 6;Integrated Security=true;"))
                .Create(new Company()
                {
                    Title = "test comp",
                    Description = "test comp",
                    Adress = new Adress()
                    {
                        City = new Models.Base.CityModel()
                        {
                            ID = 1,
                            CountryID=1,
                            Name = "Name"
                        }
                    },
                    Departments = new List<Department>()
                    {
                        new Department()
                        {
                            Title = "test1 dep",
                            Description = "test 2 dep",
                            Projects = new List<Models.Base.ProjectModel>()
                            {
                                new Models.Base.ProjectModel()
                                {
                                    Title = "test proj11",
                                    Description = "test proj11",
                                    DirectionID = 1,
                                },
                                new Models.Base.ProjectModel()
                                {
                                    Title = "test proj22",
                                    Description = "test proj22",
                                    DirectionID = 1,
                                },
                                new Models.Base.ProjectModel()
                                {
                                    Title = "test proj33",
                                    Description = "test proj33",
                                    DirectionID = 1,
                                }
                            }
                        },
                        new Department()
                        {
                            Title = "test1 dep1",
                            Description = "test 2 dep1",
                            Projects = new List<Models.Base.ProjectModel>()
                            {
                                new Models.Base.ProjectModel()
                                {
                                    Title = "test proj112",
                                    Description = "test proj112",
                                    DirectionID = 1,
                                },
                                new Models.Base.ProjectModel()
                                {
                                    Title = "test proj222",
                                    Description = "test proj222",
                                    DirectionID = 1,
                                },
                                new Models.Base.ProjectModel()
                                {
                                    Title = "test proj332",
                                    Description = "test proj332",
                                    DirectionID = 1,
                                }
                            }
                        }
                    }
                });
            //var c = new PositionService(new DBController(DBConfigurator.ConnectionString)).GetAll();
            //string str = a.ToString();
            //var a = new Employee();
            //var b = a.Clone();
            //a.Department = null;


        }
    }
}
