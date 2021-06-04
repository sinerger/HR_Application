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

namespace HR_Application_DB_WPF.ModalWindows
{
    /// <summary>
    /// Interaction logic for AddDepartment.xaml
    /// </summary>
    public partial class AddDepartmentWindow : Window
    {
        //=============>
        //=============>
        #region Загушка Данных
        private string[] _cities = new string[]
        {
            "Dnipro",
            "Kiev",
            "Moscow",
            "sankt petersburg",
            "Baku"
        };
        private string[] _companies = new string[]
        {
            "Wizardsdev",
            "SoftServe",
            "Nix"
        };
        private string[] _departments = new string[]
        {
            "Mobile",
            "CRM",
            "Web"
        };
        #endregion
        //=============>
        //=============>


        public AddDepartmentWindow()
        {
            InitializeComponent();
            SetDataCity(_cities);
            SetDataCompany(_companies);
            SetDataDepartment(_departments);
        }

        public void SetDataCity(string[] cities)
        {
            CitiesComboBox.ItemsSource = cities;
        }

        public void SetDataCompany(string[] companies)
        {
            CompaniesComboBox.ItemsSource = companies;
        }

        public void SetDataDepartment(string[] departments)
        {
            DepartmentsComboBox.ItemsSource = departments;
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Butoon_Accept_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Сохраняем данные что ввели для сотрудника

            this.Close();
        }
    }
}
