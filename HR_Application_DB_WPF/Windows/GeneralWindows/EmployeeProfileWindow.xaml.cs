using HR_Application_BLL.Models;
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
using static HR_Application_DB_WPF.Windows.GeneralWindows.HomePageWindow;

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for EmployeeProfileHistory.xaml
    /// </summary>
    public partial class EmployeeProfileWindow : Window
    {
        private Cache _cache;
        private Loader _loader;
        private Employee _employee;
        private bool _isUpdatet = false;

        public EmployeeProfileWindow(Employee employee)
        {
            _cache = Cache.GetCache();
            _loader = new Loader();
            _employee = employee.Clone();

            InitializeComponent();
        }

        private void TabItem_MouseEnter(object sender, MouseEventArgs e)
        {
            var title = (TabItem)sender;
            title.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#E3405F"));
        }

        private void TabItem_MouseLeave(object sender, MouseEventArgs e)
        {
            var title = (TabItem)sender;
            title.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#878383"));
        }

        private void TextBox_Department_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddDepartmentWindow addDepartmentWindow = new AddDepartmentWindow(_employee);
            addDepartmentWindow.Closed += AddDepartmentWindow_Closed;
            addDepartmentWindow.ShowDialog();
        }

        private void AddDepartmentWindow_Closed(object sender, EventArgs e)
        {
            if (sender is AddDepartmentWindow)
            {
                var window = (AddDepartmentWindow)sender;
                ComboBox_Project.ItemsSource = _employee.Department.Projects;
                ComboBox_Project.SelectedItem = _employee.Project;
                TextBox_Department.Text = _employee.Department.ToString();
                window.Closed -= AddDepartmentWindow_Closed;
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
            if (sender is AddDepartmentWindow)
            {
                var window = (AddDepartmentWindow)sender;
                var competencesStr = string.Empty;

                foreach (Competence competence in _employee.Competences)
                {
                    competencesStr += $"{competence.ToString()}\n";
                }

                TextBox_Competence.Text = competencesStr;
                window.Closed -= AddCompetenceWindow_Closed;
            }
        }

        private void Button_AddComment_Click(object sender, RoutedEventArgs e)
        {
            AddCommentWindow addCommentWindow = new AddCommentWindow(_employee, TextBox_Comments);

            addCommentWindow.ShowDialog();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (!_employee.Equals(_cache.SelectedEmployee))
            {
                var result = MessageBox.Show("Cancel changes?", "Cancel", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    _employee = _cache.SelectedEmployee;
                    Window_Loaded(null, null);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            SetChanges();

            if (!_employee.Equals(_cache.SelectedEmployee))
            {
                _loader.UpdateEmployee(_employee);
                _cache.SelectedEmployee = _employee;
                _isUpdatet = true;

                this.Close();
            }
            else if (_employee.Equals(_cache.SelectedEmployee))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No Profile Changes");
            }
        }

        private void SetChanges()
        {
            _employee.FirstName = TextBox_FirstName.Text;
            _employee.LastName = TextBox_LastName.Text;
            _employee.GeneralInformation.BirthDate = DatePicker_BirthDate.SelectedDate.ToString();
            _employee.GeneralInformation.Phone = TextBox_Phone.Text;
            _employee.GeneralInformation.Email = TextBox_Email.Text;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) //TODO: Change employee to _employeeFromSelect
        {
            StringBuilder competence = new StringBuilder();

            foreach (var comp in _employee.Competences)
            {
                competence.Append($"{comp.Skill} - {comp.LevelSkill}\n ");
            }

            StringBuilder comments = new StringBuilder();

            foreach (var comm in _employee.Comments)
            {
                comments.Append($"{comm.Information} - {comm.Date}\n");
            }

            TextBox_FirstName.Text = _employee.FirstName;
            TextBox_LastName.Text = _employee.LastName;
            TextBox_RegistrationDate.Text = _employee.RegistrationDate;
            DatePicker_BirthDate.SelectedDate = Convert.ToDateTime(_employee.GeneralInformation.BirthDate);
            TextBox_Phone.Text = _employee.GeneralInformation.Phone;
            TextBox_Email.Text = _employee.GeneralInformation.Email;
            TextBox_Department.Text = _employee.Department.ToString();
            TextBox_Position.Text = _employee.Position.ToString();
            TextBox_Competence.Text = competence.ToString();
            TextBox_Comments.Text = comments.ToString();
            ComboBox_Project.ItemsSource = _employee.Department.Projects;
            ComboBox_Project.SelectedItem = _employee.Project;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_isUpdatet)
            {
                _loader.UpdateEmployees();
            }
        }
    }
}
