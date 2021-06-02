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
    public partial class AddDepartment : Window
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


        public AddDepartment()
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

        private void ClickSaveButton_Event(object sender, RoutedEventArgs e)
        {
            /// ТУт что то делаем с темы данными что ввел пользователь
            this.Close();
        }

        private void ClickCancelButton_Event(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
