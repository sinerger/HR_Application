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
        private bool IsUpdatet = false;

        public EmployeeProfileWindow()
        {
            _cache = Cache.GetCache();
            _loader = new Loader();
            _employee = _cache.SelectedEmployee.Clone();

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
            AddDepartmentWindow addDepartmentWindow = new AddDepartmentWindow(_employee, TextBox_Department);
            addDepartmentWindow.ShowDialog();
        }

        private void TextBox_Position_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddPositionWindow addPositionWindow = new AddPositionWindow(_employee, TextBox_Position);
            addPositionWindow.ShowDialog();
        }

        private void TextBox_Competence_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddCompetenceWindow addCompetenceWindow = new AddCompetenceWindow(_employee, TextBox_Competence);
            addCompetenceWindow.ShowDialog();
        }

        private void Button_AddComment_Click(object sender, RoutedEventArgs e)
        {
            AddCommentWindow addCommentWindow = new AddCommentWindow(TextBox_Comments);
            addCommentWindow.ShowDialog();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (IsUpdatet)
            {
                var result = MessageBox.Show("Cancel changes?", "Cancel", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    _employee = _cache.SelectedEmployee;
                    Window_Loaded(null, null);
                }
            }
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            SetChanges();

            if (_employee != _cache.SelectedEmployee)
            {
                _loader.UpdateEmployee(_employee);
                _cache.SelectedEmployee = _employee;
                IsUpdatet = true;

                MessageBox.Show("Saved");
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
            TextBox_Project.Text = _employee.Project.ToString();
            TextBox_Comments.Text = comments.ToString();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsUpdatet)
            {
                _loader.LoadAllData();
            }
        }
    }
}
