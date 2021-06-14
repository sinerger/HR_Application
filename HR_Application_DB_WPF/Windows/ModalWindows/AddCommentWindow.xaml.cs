using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_WPF.Classes;
using HR_Application_DB_WPF.Windows.GeneralWindows;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace HR_Application_DB_WPF.Windows.ModalWindows
{
    /// <summary>
    /// Interaction logic for AddCommentWindow.xaml
    /// </summary>
    public partial class AddCommentWindow : Window
    {
        private TextBox _textBoxProfileWindow;
        public EmployeeProfileWindow profileWindow;
        private Cache _cashe;
        private Employee _employee;
        public AddCommentWindow(Employee employee,TextBox textBox)
        {
            InitializeComponent();
            _cashe = Cache.GetCache();
            _employee = employee;
            _textBoxProfileWindow = textBox;
        }

        public AddCommentWindow()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Comments.Text != string.Empty)
            {
                CommentModel comment = new CommentModel()
                {
                    Information = TextBox_Comments.Text,
                    EmployeeID = _employee.ID,
                    Date = DateTime.Now.Date.ToString("yyyy-MM-dd")
                };
                _employee.Comments.Add(comment);

                string comments = string.Empty;
                StringBuilder stringBuilderComments = new StringBuilder(comments);

                foreach (var comm in _employee.Comments)
                {
                    stringBuilderComments.Append($"{comm.Information} - {comm.Date}\n");
                }
                comments = stringBuilderComments.ToString();
                _textBoxProfileWindow.Text = comments;
            }

            this.Close();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
