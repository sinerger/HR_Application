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

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomePageWindow : Window
    {
        private Cache _cache;


        public HomePageWindow()
        {
            _cache = Cache.GetCache();
            InitializeComponent();

            DataContext = _cache.SelectedEmployee;
            //ComboboxDepartments.ItemsSource = _cache.Departments;


            InitializeUserData();


            DataGrid_Employees.ItemsSource = _cache.Employees;
            AllEmployeeGrid.ItemsSource = _cache.Employees;
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

        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {

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
            if (!(DataGrid_Employees.SelectedItem is null))
            {
                _cache.SelectedEmployee = DataGrid_Employees.SelectedItem as Employee;

                EmployeeProfileWindow editEmployeeWindow = new EmployeeProfileWindow();
                editEmployeeWindow.ShowDialog();
            }
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            TxtCountEmployeeInAppAll.Text = _cache.Employees.Count.ToString();
            TxtCountHRInApp.Text = _cache.Users.Count.ToString();
            TxtCountPeopleInApp.Text = ((_cache.Employees.Count) + (_cache.Users.Count)).ToString();
            ComboboxEmployees.ItemsSource = _cache.PositionsModels;
            ComboboxEmployees.SelectedItem = _cache.PositionsModels[0];

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
                if (curDepartment.Title == selectDep.Title/*curDepartment.Equals((Department)ComboboxDepartments.SelectedItem)*/)
                {
                    ++count;
                }
            }

            TxtCountEmployeeInDepartment.Text = count.ToString();
        }
    }
}
