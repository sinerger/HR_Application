using HR_Application_BLL;
using HR_Application_BLL.Models;
using HR_Application_DB_WPF.Classes;
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
    public partial class ChangePasswordWindow : Window
    {
        private Cache _cache;
        private User _user;

        public ChangePasswordWindow()
        {
            InitializeComponent();
            _cache = Cache.GetCache();
            _user = new User();
        }

        private void ChangePassword()
        {
            _user.Password = Cryptography.GetHash(TextBox_NewPassword.Text);

            try
            {
                AuthorizationController.RegistrationNewUser(_user);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            _cache.SelectedCompany = null;
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Поменять пароль у пользователя

            bool isConfirm = true;

            if (!(_user.Password.Equals(TextBox_CurrentPassword.Text)))
            {
                MessageBox.Show("Invalid Current password");

                isConfirm = false;
            }
            else if (!(AuthorizationController.IsValidPassword(TextBox_NewPassword.Text))
                && !(AuthorizationController.IsValidPassword(TextBox_ConfirmPassword.Text)))
            {
                MessageBox.Show("Invalid New password");

                isConfirm = false;
            }
            else if (TextBox_NewPassword.Text == TextBox_ConfirmPassword.Text)
            {
                MessageBox.Show("New password must be equal to Confirm password");

                isConfirm = false;
            }
            else if (TextBox_NewPassword.Text.Length < 8 || TextBox_ConfirmPassword.Text.Length < 8)
            {
                MessageBox.Show("Password >= 8");

                isConfirm = false;
            }

            if (isConfirm)
            {
                ChangePassword();

                HomePageWindow homePageWindow = new HomePageWindow();
                homePageWindow.Show();

                this.Close();
            }

            this.Close();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
