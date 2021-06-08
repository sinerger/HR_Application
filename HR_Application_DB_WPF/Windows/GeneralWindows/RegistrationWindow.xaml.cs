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

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Отправляем данные 
            // TODO: Проверяем можно ли зарегестрироваться 

            if (AuthorizationController.IsValidEmail(TextBox_Login.Text))
            {
                if (AuthorizationController.IsValidPassword(TextBox_Password.Text)
                    && AuthorizationController.IsValidPassword(TextBox_Password.Text))
                {
                    UserModel user = CreateUser();

                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            else
            {
                MessageBox.Show("Invalid email");
            }
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();

            this.Close();
        }

        private UserModel CreateUser()
        {
            UserModel user = new UserModel();

            return user;
        }
    }
}
