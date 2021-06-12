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
        private Cache _cashe;
        public EmployeeTest employee;
        private Employee _employeeFromSelect;
        public EmployeeProfileWindow()
        {
            InitializeComponent();
            _cashe = Cache.GetCache();
            _employeeFromSelect = _cashe.SelectedEmployee;
        }

        public EmployeeProfileWindow(EmployeeTest fromEmployee)
        {
            employee = fromEmployee;
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
            title.Foreground =(SolidColorBrush)(new BrushConverter().ConvertFrom("#878383"));
        }

        private void TextBox_Department_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //AddDepartmentWindow addDepartmentWindow = new AddDepartmentWindow();
            //addDepartmentWindow.ShowDialog();
        }

        private void TextBox_Position_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddPositionWindow addPositionWindow = new AddPositionWindow();
            addPositionWindow.ShowDialog();
        }

        private void TextBox_Competence_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddCompetenceWindow addCompetenceWindow = new AddCompetenceWindow(employee.Competence);
            addCompetenceWindow.ShowDialog();
        }

        private void Button_AddComment_Click(object sender, RoutedEventArgs e)
        {
            AddCommentWindow addCommentWindow = new AddCommentWindow(employee, CommentsTextBox);
            addCommentWindow.ShowDialog();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            //TODO:откат данных из модели Employee profile
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            //TODO:Сохранение данных в моделе Employee profile
            //this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) //TODO: Change employee to _employeeFromSelect
        {
            string competence = string.Empty;
            StringBuilder stringBuilderCompetence = new StringBuilder(competence);

            foreach (var comp in employee.Competence)
            {
                stringBuilderCompetence.Append($"{comp.Skill} - {comp.LevelSkill}, ");
            }
            competence = stringBuilderCompetence.ToString();

            string comments = string.Empty;
            StringBuilder stringBuilderComments = new StringBuilder(comments);

            foreach(var comm in employee.Comments)
            {
                stringBuilderComments.Append($"{comm.Information} - {comm.Date}\n");
            }
            comments = stringBuilderComments.ToString();

            FirstNameTextBox.Text = employee.FirstName;
            LastNameTextBox.Text = employee.LastName;
            RegistrationDateTextBox.Text = employee.RegistrationDate;
            DateOfBirthDatePicker.SelectedDate = Convert.ToDateTime(employee.GeneralInformation.BirthDate);
            PhoneTextBox.Text = employee.GeneralInformation.Phone;
            EmailTextBox.Text = employee.GeneralInformation.Email;
            DepartmentTextBox.Text = employee.Department.Title;
            PositionTextBox.Text = employee.Position.Title;
            CompetenceTextBox.Text = competence.Remove(competence.Length - 2);
            ProjectNameTextBox.Text = employee.Project.Title;
            CommentsTextBox.Text = comments;
        }
    }
}
