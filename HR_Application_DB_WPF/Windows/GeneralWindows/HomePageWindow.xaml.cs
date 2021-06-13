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
using System.Linq;
using HR_Application_BLL.Base.Models;
using System.Windows.Input;

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomePageWindow : Window
    {
        private Cache _cache;
        private CompanyService _companyService;
        private Company _company;
        private Department _department;
        private ProjectModel _project;

        public HomePageWindow()
        {
            _cache = Cache.GetCache();

            InitializeComponent();
            InitializeUserData();
            InitializeEmployeesData();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            TxtCountEmployeeInAppAll.Text = _cache.Employees.Count.ToString();
            TxtCountHRInApp.Text = _cache.Users.Count.ToString();
            TxtCountPeopleInApp.Text = ((_cache.Employees.Count) + (_cache.Users.Count)).ToString();
            ComboboxEmployees.ItemsSource = _cache.PositionsModels;
            ComboboxEmployees.SelectedItem = _cache.PositionsModels[0];

            DataGrid_Company.ItemsSource = _cache.Companies;
            DataGrid_Company.IsReadOnly = false;

            var departmetns = new List<Department>();

            foreach (var departmetn in _cache.Departments)
            {
                if (departmetns.FirstOrDefault(dep => dep.Title == departmetn.Title) == null)
                {
                    departmetns.Add(departmetn.Clone());
                }
            }

            ComboboxDepartments.ItemsSource = departmetns;

            if (departmetns.Count > 0)
            {
                ComboboxDepartments.SelectedItem = departmetns[0];
            }

            ComboBox_City.ItemsSource = _cache.Cities;
        }

        private void InitializeEmployeesData()
        {
            DataContext = _cache.SelectedEmployee;
            DataGrid_AllEmployees.ItemsSource = _cache.Employees;
            //DataGrid_Employees.ItemsSource = _cache.Employees;
        }

        private void InitializeUserData()
        {
            TextBox_FirstName.Text = $"{_cache.CurrentUser.FirstName}";
            TextBox_LastName.Text = $"{_cache.CurrentUser.LastName}";
            TextBox_Company.Text = _cache.CurrentUser.Company.ToString();
            TextBox_City.Text = _cache.CurrentUser.Company.Adress.City.ToString();
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

        private void TextBox_Company_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            AddDepartmentWindow addDepartmentWindow = new AddDepartmentWindow(_cache.CurrentUser);
            addDepartmentWindow.Closed += AddDepartmentWindow_Closed;
            addDepartmentWindow.ShowDialog();
        }

        private void AddDepartmentWindow_Closed(object sender, EventArgs e)
        {
            if (sender is AddDepartmentWindow)
            {
                var window = (AddDepartmentWindow)sender;
                TextBox_Company.Text = _cache.CurrentUser.Company.ToString();
                window.Closed -= AddDepartmentWindow_Closed;
            }
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
                editEmployeeWindow.Closing += EditEmployeeWindow_Closing;
                editEmployeeWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chose employee and try again", "Warning", MessageBoxButton.OK);
            }
        }

        private void EditEmployeeWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            InitializeEmployeesData();
            if (sender is EmployeeProfileWindow)
            {
                var window = (EmployeeProfileWindow)sender;
                window.Closing -= EditEmployeeWindow_Closing;
            }
        }

        private void FindEmployeeButton_Edit_Click(object sender, RoutedEventArgs e)
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

        private void ComboboxEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int count = 0;
            var allPosition = new List<Position>(_cache.Employees.Select(emplo => emplo.Position));

            foreach (Position curPosition in allPosition)
            {
                if (curPosition.Post.Equals((PositionModel)ComboboxEmployees.SelectedItem))
                {
                    ++count;
                }
            }

            TxtCountEmployeeInApp.Text = count.ToString();
        }

        private void ComboboxDepartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int count = 0;
            var allEmployee = new List<Department>(_cache.Employees.Select(emplo => emplo.Department));
            var selectDep = (Department)ComboboxDepartments.SelectedItem;

            foreach (Department curDepartment in allEmployee)
            {
                if (curDepartment.Title == selectDep.Title)
                {
                    ++count;
                }
            }

            TxtCountEmployeeInDepartment.Text = count.ToString();
        }

        private void DataGrid_Company_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(DataGrid_Company.SelectedItem is null))
            {
                if (DataGrid_Company.SelectedItem is Company)
                {
                    _company = DataGrid_Company.SelectedItem as Company;
                    ComboBox_City.IsEditable = false;
                    ComboBox_City.SelectedItem = _company.Adress.City;
                    DataGrid_Department.ItemsSource = _company.Departments;
                }
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

        private void CreateCompany()
        {
            if (!(string.IsNullOrEmpty(TextBox_Title.Text) && string.IsNullOrEmpty(TextBox_Description.Text)))
            {
                _company = new Company()
                {
                    Title = TextBox_Title.Text,
                    Description = TextBox_Description.Text,
                    Departments = new List<Department>()
                    {
                        new Department()
                        {
                            Title = "Without department",
                            Projects = new List<ProjectModel>()
                            {
                                new ProjectModel()
                                {
                                    Title = "Without project"
                                }
                            }
                        }
                    },
                    Adress = new Adress()
                    {
                        City = (CityModel)ComboBox_City.SelectedItem
                    }
                };
                // TODO : Создание компании 
            }
        }

        private void UpdateDataGridCompny()
        {
            DataGrid_Company.ItemsSource = _cache.Companies;
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButtonCompanies.IsChecked == true)
            {
                
            }
            //if (RadioButtonDepartments.IsChecked == true)
            //{
            //    if (!(string.IsNullOrEmpty(TextBox_Title.Text) && string.IsNullOrEmpty(TextBox_Description.Text)))
            //    {
            //        Department newDepartment = new Department();
            //        newDepartment.Title = TextBox_Title.Text;
            //        newDepartment.Description = TextBox_Description.Text;
            //        newDepartment.Projects = null;

            //        //_companyService.Add(newCompany);
            //    }
            //}
            //if (RadioButtonProjects.IsChecked == true)
            //{
            //    if (!(string.IsNullOrEmpty(TextBox_Title.Text) && string.IsNullOrEmpty(TextBox_Description.Text)))
            //    {
            //        ProjectModel newProject = new ProjectModel();
            //        newProject.DirectionID = 1;
            //        newProject.Title = TextBox_Title.Text;
            //        newProject.Description = TextBox_Description.Text;
            //    }
            //}
        }
    }
}
