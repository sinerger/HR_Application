using HR_Application_BLL;
using HR_Application_BLL.Base.Models;
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
using HR_Application_BLL.Models;
using HR_Application_BLL.Services;
using HR_Application_DB_Logic;
using HR_Application_DB_WPF.Classes;
using HR_Application_DB_WPF.ModalWindows;

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private Cache _cache;
        private User _user;
        public RegistrationWindow()
        {
            InitializeComponent();
            _cache = Cache.GetCache();
        }

        private void CreateUser()
        {
            _user.FirstName = TextBox_FirstName.Text;
            _user.LastName = TextBox_LastName.Text;
            _user.Email = TextBox_Login.Text;
            _user.Password = TextBox_Password.Text;
            _user.Company = _cache.SelectedCompany;


            new UserService(new DBController(DBConfigurator.ConnectionString)).Create(_user);

            _cache.SelectedCompany = null;
        }

        private void TextBox_Company_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddDepartmentWindow addDepWindow = new AddDepartmentWindow(_user,(TextBox)sender);
            addDepWindow.ShowDialog();
        }

        private void TextBox_Company_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (_cache.SelectedCompany != null)
            {
                TextBox_City.Text = _cache.SelectedCompany.Adress.City.ToString();
            }
        }

        private void Button_Regist_Click(object sender, RoutedEventArgs e)
        {
            bool isConfirm = true;

            if (_cache.Users.Find(user => user.Email == TextBox_Login.Text) != null)
            {
                MessageBox.Show("This email already exists ");

                isConfirm = false;
            }
            else if (!AuthorizationController.IsValidEmail(TextBox_Login.Text))
            {
                MessageBox.Show("Invalid email");

                isConfirm = false;
            }
            else if (TextBox_Password.Text != TextBox_ConfirmPassword.Text
                     && !AuthorizationController.IsValidPassword(TextBox_Password.Text))
            {
                MessageBox.Show("Invalid password");

                isConfirm = false;
            }
            else if (TextBox_FirstName.Text == string.Empty)
            {
                MessageBox.Show("Enter first name");

                isConfirm = false;
            }
            else if (TextBox_LastName.Text == string.Empty)
            {
                MessageBox.Show("Enter last name");

                isConfirm = false;
            }

            if (isConfirm)
            {
                CreateUser();

                AuthorizationWindow authorizationWindow = new AuthorizationWindow();
                authorizationWindow.Show();

                this.Close();
            }
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();

            this.Close();
        }
    }
}
