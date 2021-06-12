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

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        private Employee newEmployee;
        private Cache _cache;
        private Loader loader = new Loader();
        public AddEmployeeWindow()
        {
            _cache = Cache.GetCache();
            InitializeComponent();
            TextBox_Registration.Text = DateTime.Now.Date.ToString("yyyy-mm-dd");
        }

        private void TextBox_Department_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //AddDepartmentWindow addDepartment = new AddDepartmentWindow();
            //addDepartment.ShowDialog();
        }

        private void TextBox_Position_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddPositionWindow addPositionWindow = new AddPositionWindow();
            addPositionWindow.ShowDialog();
        }

        private void TextBox_Competence_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddCompetenceWindow addCompetenceWindow = new AddCompetenceWindow();
            addCompetenceWindow.ShowDialog();
        }
        private void TextBox_ProjectName_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

            if (isConfirm)
            {
            newEmployee.FirstName = TextBox_FirstName.Text;
            newEmployee.LastName = TextBox_LastName.Text;
            newEmployee.GeneralInformation.BirthDate = DatePicker_BirthDate.SelectedDate.ToString();
            newEmployee.GeneralInformation.Phone = TextBox_Phone.Text;
            newEmployee.GeneralInformation.Email = TextBox_Email.Text;
            newEmployee.RegistrationDate = DateTime.Now.Date.ToString("yyyy-mm-dd");
            newEmployee.Department = _cache.SelectedCompany.Departments[0]; //UNDONE: think about put department as List
            newEmployee.Position = _cache.SelectedPosition;
            newEmployee.Competences = _cache.SelectedCompetences;
            newEmployee.Project = _cache.SelectedProject;

            loader.CreateEmployee(newEmployee);
            this.Close();
            }
        }

    }
}
