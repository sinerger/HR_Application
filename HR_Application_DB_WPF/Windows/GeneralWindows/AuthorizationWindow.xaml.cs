using HR_Application_BLL;
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
    /// Interaction logic for Authorisation.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private const string _defaultTextLogin = "Login";
        private const string _defaultTextPassword = "Password";

        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void SignInButton__Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AuthorizationController.SignIn(TextBox_Login.Text, TextBox_Password.Text))
                {
                    HomePageWindow homePageWindow = new HomePageWindow();
                    homePageWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid login or password");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("The server is not responding. from try later");
            }
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();

            this.Close();
        }
    }
}
