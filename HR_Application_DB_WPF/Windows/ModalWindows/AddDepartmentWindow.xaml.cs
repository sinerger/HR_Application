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
using HR_Application_BLL;
using HR_Application_BLL.Models;
using HR_Application_BLL.Services;
using HR_Application_DB_Logic;
using HR_Application_DB_WPF.Classes;
using System.Linq;
using HR_Application_BLL.Models.Base;

namespace HR_Application_DB_WPF.ModalWindows
{
    /// <summary>
    /// Interaction logic for AddDepartment.xaml
    /// </summary>
    public partial class AddDepartmentWindow : Window
    {
        private Cache _cache;
        private TextBox _textBoxCompany;

        public AddDepartmentWindow(TextBox textBoxCompany)
        {
            InitializeComponent();
            _cache = Cache.GetCache();
            _textBoxCompany = textBoxCompany;
            InitializeComboBoxSources();
        }

        private void InitializeComboBoxSources()
        {
            if (_cache.Companies == null)
            {
                _cache.Companies = new CompanyService(new DBController(DBConfigurator.ConnectionString)).GetAll();
            }

            var cities = _cache.Companies.Select(city => city.Adress.City);
            ComboBox_Cities.ItemsSource = cities;
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Butoon_Accept_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBox_Companies.SelectedItem is Company)
            {
                _cache.SelectedCompany = (Company)ComboBox_Companies.SelectedItem;
                _textBoxCompany.Text = _cache.SelectedCompany.ToString();

                this.Close();
            }
            else
            {
                MessageBox.Show("Enter city, company and department");
            }
        }

        private void ComboBox_Cities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var companies = _cache.Companies.Select(company => company)
                .Where(company => company.Adress.City.Equals((CityModel)ComboBox_Cities.SelectedItem));

            if (companies != null)
            {
                ComboBox_Companies.ItemsSource = companies;
                ComboBox_Departments.ItemsSource = null;
            }
        }

        private void ComboBox_Companies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentCompany = _cache.Companies.Find(comp => comp.Equals((Company)ComboBox_Companies.SelectedItem));

            if (currentCompany != null)
            {
                ComboBox_Departments.ItemsSource = currentCompany.Departments;
            }
            else
            {
                ComboBox_Departments.ItemsSource = null;
            }
        }
    }
}
