using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using HR_Application_DB_Logic.Models;
using Dapper;
using HR_Application_DB_Logic.Interfaces;
using System;
using HR_Application_DB_Logic.Models.Base;

namespace HR_Application_DB_Logic.Repositories
{
    public class DepartmentProjectsRepository : IRepository<DepartmentProjectDTO>
    {
        public string ConnectionString { get; private set; }

        public DepartmentProjectsRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<DepartmentProjectDTO> GetAll()
        {
            string query = "[HRAppDB].GetDepartmentsProjects";
            List<DepartmentProjectDTO> result = new List<DepartmentProjectDTO>();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.Query<DepartmentProjectDTO>(query).AsList<DepartmentProjectDTO>();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public List<DepartmentProjectDTO> GetAllByDepartmentID(int departmentID)
        {
            string query = "[HRAppDB].GetDepartmentsProjectsByDepartmentID";
            List<DepartmentProjectDTO> departmentProjects = new List<DepartmentProjectDTO>();

            try
            {
                using(IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    dbConnection.Query<DepartmentProjectDTO, DepartmentDTO, int, DepartmentProjectDTO>(query,
                        (departmentProject, department, projectID) =>
                        {
                            DepartmentProjectDTO currentDP = null;

                            foreach (DepartmentProjectDTO dP in departmentProjects)
                            {
                                if (dP.Department.ID == department.ID)
                                {
                                    currentDP = departmentProject;
                                    dP.ProjectsID.Add(projectID);
                                    break;
                                }
                            }

                            if (currentDP == null)
                            {
                                currentDP = departmentProject;
                                departmentProjects.Add(currentDP);
                                currentDP.Department = department;
                                currentDP.ProjectsID = new List<int>();
                                currentDP.ProjectsID.Add(projectID);
                            }

                            return departmentProject;
                        }, new { departmentID })
                        .AsList<DepartmentProjectDTO>();
                }
            }
            catch
            {
                departmentProjects = null;
            }

            return departmentProjects;
        }

        public DepartmentProjectDTO GetByID(int id)
        {
            string query = "[HRAppDB].GetDepartmentProjectsByDepartmentID @ID";
            DepartmentProjectDTO result = new DepartmentProjectDTO();

            try
            {
                using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    result = dbConnection.QuerySingle<DepartmentProjectDTO>(query, new { id });
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public bool Update(DepartmentProjectDTO obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create(DepartmentProjectDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
