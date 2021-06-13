using HR_Application_BLL.Models;
using HR_Application_BLL.Services;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_WPF.Classes;
using HR_Application_DB_WPF.ModalWindows;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomePageWindow : Window
    {
        private Cache _cache;
        private CompanyService _companyService;
        private Company newCompany;
        private Department newDepartment;
        private ProjectModel newProject;

        public HomePageWindow()
        {
            InitializeComponent();
            _cache = Cache.GetCache();
            DataContext = _cache.SelectedEmployee;

            InitializeUserData();

            DataGrid_AllEmployees.ItemsSource = _cache.Employees;
            DataGrid_Company.ItemsSource = _cache.Companies;
        }

        private void InitializeUserData()
        {
            TextBox_Name.Text = $"{_cache.CurrentUser.FirstName} {_cache.CurrentUser.LastName}";
            TextBox_Company.Text = _cache.CurrentUser.Company.ToString();
            TextBox_City.Text = _cache.CurrentUser.Company.Adress.City.ToString();
        }

        private void DataGridCell_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            // TODO: Запретить редактирование ячеек в таблицах 
        }

        private void Button_OpenFilterWindow_Click(object sender, RoutedEventArgs e)
        {
            FilterWindow filter = new FilterWindow();
            filter.ShowDialog();
        }

        private void Button_ClearFilter_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Очистка фильтра
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Поиск сотрудников по фильтру
        }


        private void Button_LogOut_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Убрать пользователя 

            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();

            this.Close();
        }

        private void Button_ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow();
            changePasswordWindow.ShowDialog();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Сохранить изменение данных пользователя 
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Отменить изменения данных пользователя
        }

        private void Button_AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.ShowDialog();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButtonCompanies.IsChecked == true)
            {
                if (!(string.IsNullOrEmpty(TextBox_Title.Text) && string.IsNullOrEmpty(TextBox_Description.Text)))
                {
                    newCompany = new Company()
                    {
                        Title = TextBox_Title.Text,
                        Desctiption = TextBox_Description.Text,
                        Departments = new List<Department>(),
                        Adress = new Adress()
                        {
                            City = new CityModel() { ID = 1, Name = "1", CountryID = 1 }
                        }

                        //_companyService.Add(newCompany);
                    };
                }
            }
            if (RadioButtonDepartments.IsChecked == true)
            {
                if (!(string.IsNullOrEmpty(TextBox_Title.Text) && string.IsNullOrEmpty(TextBox_Description.Text)))
                {
                    Department newDepartment = new Department();
                    newDepartment.Title = TextBox_Title.Text;
                    newDepartment.Description = TextBox_Description.Text;
                    newDepartment.Projects = null;

                    //_companyService.Add(newCompany);
                }
            }
            if (RadioButtonProjects.IsChecked == true)
            {
                if (!(string.IsNullOrEmpty(TextBox_Title.Text) && string.IsNullOrEmpty(TextBox_Description.Text)))
                {
                    ProjectModel newProject = new ProjectModel();
                    newProject.DirectionID = 1; 
                    newProject.Title = TextBox_Title.Text;
                    newProject.Description = TextBox_Description.Text;
                }
            }
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButtonCompanies.IsChecked == true)
            {
                var company = DataGrid_Company.SelectedItem as Company;

                if (MessageBox.Show($"Do you really want to delete company '{company.Title}'?", "Delete Row", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
                    return;
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (RadioButtonDepartments.IsChecked == true)
            {
                var department = DataGrid_Department.SelectedItem as Department;

                if (MessageBox.Show($"Do you really want to delete department '{department.Title}'?", "Delete Row", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
                    return;
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (RadioButtonProjects.IsChecked == true)
            {
                var project = DataGrid_Project.SelectedItem as ProjectModel;

                if (MessageBox.Show($"Do you really want to delete project '{project.Title}'?", "Delete Row", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
                    return;
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_SaveUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_Company_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var AddDepWindow = new AddDepartmentWindow(_cache.CurrentUser, (TextBox)sender);

            AddDepWindow.ShowDialog();
        }

        private void TextBox_Company_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (_cache.SelectedCompany != null)
            {
                TextBox_City.Text = _cache.SelectedCompany.ToString();
            }
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (!(DataGrid_AllEmployees.SelectedItem is null))
            {
                _cache.SelectedEmployee = DataGrid_AllEmployees.SelectedItem as Employee;

                EmployeeProfileWindow editEmployeeWindow = new EmployeeProfileWindow(_cache.SelectedEmployee);
                editEmployeeWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chose employee and try again", "Warning", MessageBoxButton.OK);
            }
        }

        private void FindEmployeeButton_Edit_Click(object sender, RoutedEventArgs e)// TODO: add new event
        {
            if (!(_cache.SelectedEmployee is null))
            {
                _cache.SelectedEmployee = DataGrid_Employees.SelectedItem as Employee;

                EmployeeProfileWindow editEmployeeWindow = new EmployeeProfileWindow(_cache.SelectedEmployee);
                editEmployeeWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chose employee and try again", "Warning", MessageBoxButton.OK);
            }
        }

        private void DataGrid_Company_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(DataGrid_Company.SelectedItem is null))
            {
                var company = DataGrid_Company.SelectedItem as Company;
                DataGrid_Department.ItemsSource = company.Departments;
            }
        }

        private void DataGrid_Department_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(DataGrid_Department.SelectedItem is null))
            {
                var department = DataGrid_Department.SelectedItem as Department;
                DataGrid_Project.ItemsSource = department.Projects;
            }
        }
    }
}
