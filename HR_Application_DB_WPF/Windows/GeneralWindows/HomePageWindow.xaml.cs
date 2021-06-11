using HR_Application_DB_WPF.Classes;
using HR_Application_DB_WPF.ModalWindows;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomePageWindow : Window
    {
        public class Employee
        {
            public string FullName { get; set; }
            public string Level { get; set; }
            public string Direction { get; set; }
        }

        private Cache _cache;

        public HomePageWindow()
        {
            InitializeComponent();
            _cache = Cache.GetCache();

            InitializeUserData();

            DataGrid_Employees.ItemsSource = new List<Employee>()
            {
                new Employee()
                {
                    FullName = "qqq",
                    Level = "1",
                    Direction = "ddd"
                }
            };
        }

        private void InitializeUserData()
        {
            TextBox_Name.Text = $"{_cache.CurrentUser.FirstName} {_cache.CurrentUser.LastName}";
            TextBox_Company.Text = _cache.CurrentUser.Company.ToString();
        }

        private void DataGridCell_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            var dataGridCellTarget = (DataGridCell)sender;
            // TODO: Запретить редактирование ячеек в таблицах 
            
            EmployeeProfileWindow employeeProfileWindow = new EmployeeProfileWindow();
            employeeProfileWindow.ShowDialog();
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
            var AddDepWindow = new AddDepartmentWindow((TextBox)sender);

            AddDepWindow.ShowDialog();
        }

        private void TextBox_Company_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (_cache.SelectedCompany != null)
            {
                TextBox_City.Text = _cache.SelectedCompany.ToString();
            }
        }
    }
}
