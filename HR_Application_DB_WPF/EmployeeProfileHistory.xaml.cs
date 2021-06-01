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

namespace HR_Application_DB_WPF
{
    /// <summary>
    /// Interaction logic for EmployeeProfileHistory.xaml
    /// </summary>
    public partial class EmployeeProfileHistory : Window
    {
        public EmployeeProfileHistory()
        {
            InitializeComponent();
        }

        private void TabItem_MouseEnter(object sender, MouseEventArgs e)
        {
            var obj = (TabItem)sender;
            obj.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#E3405F"));
        }

        private void TabItem_MouseLeave(object sender, MouseEventArgs e)
        {
            var obj = (TabItem)sender;
            obj.Foreground =(SolidColorBrush)(new BrushConverter().ConvertFrom("#878383"));
        }
    }
}
