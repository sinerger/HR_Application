using HR_Application_BLL;
using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_WPF.Classes;
using HR_Application_DB_WPF.ModalWindows;
using HR_Application_DB_WPF.Windows.ModalWindows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        private Employee _employee;
        private Cache _cache;
        private Loader _loader;

        public AddEmployeeWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _cache = Cache.GetCache();
            _loader = new Loader();
            _employee = new Employee();
            TextBox_Registration.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
            ComboBox_City.Items.Clear();
            ComboBox_City.ItemsSource = _cache.Cities;
        }

        private void TextBox_Department_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddDepartmentWindow addDepartment = new AddDepartmentWindow(_employee);
            addDepartment.Closed += AddDepartment_Closed;
            addDepartment.ShowDialog();
        }

        private void AddDepartment_Closed(object sender, EventArgs e)
        {
            if (sender is AddDepartmentWindow)
            {
                var window = (AddDepartmentWindow)sender;

                //ComboBox_Project.Items.Clear();
                ComboBox_Project.ItemsSource = _employee.Department.Projects;
                ComboBox_Project.SelectedItem = _employee.Project;
                TextBox_Department.Text = _employee.Department.ToString();

                window.Closed -= AddDepartment_Closed;
            }
        }

        private void TextBox_Position_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddPositionWindow addPositionWindow = new AddPositionWindow(_employee);
            addPositionWindow.Closed += AddPositionWindow_Closed;
            addPositionWindow.ShowDialog();
        }

        private void AddPositionWindow_Closed(object sender, EventArgs e)
        {
            if (sender is AddPositionWindow)
            {
                var window = (AddPositionWindow)sender;
                TextBox_Position.Text = _employee.Position.ToString();
                window.Closed -= AddPositionWindow_Closed;
            }
        }

        private void TextBox_Competence_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddCompetenceWindow addCompetenceWindow = new AddCompetenceWindow(_employee);
            addCompetenceWindow.Closed += AddCompetenceWindow_Closed;
            addCompetenceWindow.ShowDialog();
        }

        private void AddCompetenceWindow_Closed(object sender, EventArgs e)
        {
            if (sender is AddCompetenceWindow)
            {
                var window = (AddCompetenceWindow)sender;
                var competencesStr = string.Empty;

                foreach (Competence competence in _employee.Competences)
                {
                    competencesStr += $"{competence.ToString()}\n";
                }

                TextBox_Competence.Text = competencesStr;
                window.Closed -= AddDepartment_Closed;
            }
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Cancel?", "Cancel", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            bool isConfirm = true;

            if (TextBox_FirstName.Text == string.Empty)
            {
                MessageBox.Show("Enter first name");

                isConfirm = false;
            }
            else if (TextBox_LastName.Text == string.Empty)
            {
                MessageBox.Show("Enter last name");

                isConfirm = false;
            }
            else if (TextBox_Phone.Text == string.Empty)
            {
                MessageBox.Show("Enter phone");

                isConfirm = false;
            }
            else if (TextBox_Email.Text == string.Empty)
            {
                MessageBox.Show("Enter email");

                isConfirm = false;
            }
            else if (_employee.Company.ID == 0)
            {
                MessageBox.Show("Enter company");

                isConfirm = false;
            }
            else if (_employee.Position.Post.Title == null)
            {
                MessageBox.Show("Enter position");

                isConfirm = false;
            }
            else if (_employee.Competences.Count == 0)
            {
                MessageBox.Show("Enter competence");

                isConfirm = false;
            }
            else if (_employee.Project.Title == null)
            {
                MessageBox.Show("Enter project");

                isConfirm = false;
            }
            else if (_employee.Adress.City.Name == null)
            {
                MessageBox.Show("Enter city");

                isConfirm = false;
            }

            if (isConfirm)
            {
                _employee.FirstName = TextBox_FirstName.Text;
                _employee.LastName = TextBox_LastName.Text;
                _employee.GeneralInformation.BirthDate = DatePicker_BirthDate.SelectedDate.ToString();
                _employee.GeneralInformation.Phone = TextBox_Phone.Text;
                _employee.GeneralInformation.Email = TextBox_Email.Text;
                _employee.RegistrationDate = DateTime.Now.Date.ToString("yyyy-MM-dd");


                _loader.CreateEmployee(_employee);

                this.Close();
            }
        }

        private void ComboBox_City_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox_City.SelectedItem is CityModel)
            {
                _employee.Adress = new Adress()
                {
                    City = (CityModel)ComboBox_City.SelectedItem
                };
            }
        }

        private void ComboBox_Project_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox_Project.SelectedItem is ProjectModel)
            {
                _employee.Project = (ProjectModel)ComboBox_Project.SelectedItem;
            }
        }
    }
}
