using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HRAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyAccount : Window
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        public class Employee
        {
            public string FullName { get; set; }
            public string Level { get; set; }
            public int Direction { get; set; }
        }
        List<Employee> employeeList = new List<Employee>
{
    new Employee { FullName="Ivan", Level="middle", Direction=111 },
    new Employee {FullName="Ivan", Level="middle", Direction=222 },
    new Employee {FullName="Ivan", Level="middle", Direction=333 }
};


        private void HyperlinkFindEmployee_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello from FindEmployee Window:)", "Hello USER!!!", MessageBoxButton.OK);
            //FindEmployee formFindEmployee = new FindEmployee();
            //formFindEmployee.Show();
        }

        private void HyperlinkStats_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello from Stats Window:)", "Hello USER!!!", MessageBoxButton.OK);
            //Stats formStats = new Stats();
            //formStats.Show();
        }

        private void HyperlinkAllEmployee_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello from AllEmployee Window:)", "Hello USER!!!", MessageBoxButton.OK);
            //AllEmployee formAllEmployee = new AllEmployee();
            //formAllEmployee.Show();
        }

        private void ButtonLogOut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello from LogIn Window:)", "Hello USER!!!", MessageBoxButton.OK);
            //LogOut formLogOut = new LogOut();
            //formLogOut.Show();
        }

        private void ButtonChangePassword_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello from ChangePassword Window:)", "Hello USER!!!", MessageBoxButton.OK);
            //ChangePassword formChangePassword = new ChangePassword();
            //formChangePassword.ShowModal();
        }

        private void TxtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
