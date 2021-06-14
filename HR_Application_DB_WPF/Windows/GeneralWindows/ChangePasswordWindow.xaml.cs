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
        public ChangePasswordWindow()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Поменять пароль у пользователя
            this.Close();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PasswordBox_ChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            Watermark_ChangePassword.Visibility = Visibility.Collapsed;
        }

        private void PasswordBox_NewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Watermark_NewPassword.Visibility = Visibility.Collapsed;
        }

        private void PasswordBox_ConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Watermark_ConfirmPassword.Visibility = Visibility.Collapsed;
        }
    }
}
