using HR_Application_BLL.Models.Base;
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

namespace HR_Application_DB_WPF.Windows.ModalWindows
{
    /// <summary>
    /// Interaction logic for AddCommentWindow.xaml
    /// </summary>
    public partial class AddCommentWindow : Window
    {
        private Cache _cache;
        private List<CommentModel> _commentEmployee;

        public AddCommentWindow()
        {
            InitializeComponent();
            _cache = Cache.GetCache();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
