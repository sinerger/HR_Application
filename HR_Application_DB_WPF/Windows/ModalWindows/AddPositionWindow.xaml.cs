using HR_Application_BLL.Base.Models;
using HR_Application_BLL.Models;
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
using static HR_Application_DB_WPF.Windows.GeneralWindows.HomePageWindow;

namespace HR_Application_DB_WPF.Windows.ModalWindows
{
    /// <summary>
    /// Interaction logic for AddPositionWindow.xaml
    /// </summary>
    public partial class AddPositionWindow : Window
    {
        private Cache _cache;
        private TextBox _textBoxPosition;
        private Employee _employee;

        public AddPositionWindow(Employee employee, TextBox textBoxPosition)
        {
            _cache = Cache.GetCache();
            _employee = employee;
            _textBoxPosition = textBoxPosition;
            InitializeComponent();
            SetDataPosition();
            SetDataLevelPosition();
        }

        public void SetDataPosition()
        {
            ComboBox_Position.ItemsSource = _cache.PositionsModels;
        }

        public void SetDataLevelPosition()
        {
            ComboBox_LevelPosition.ItemsSource = _cache.levelsPositionModels;
        }

        private void Button_Accept_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Сохраняем данные что ввели для сотрудника
            if (_employee.Position.Post == (PositionModel)ComboBox_Position.SelectedItem
                && _employee.Position.Level == (LevelsPositionModel)ComboBox_LevelPosition.SelectedItem)
            {
                this.Close();
            }
            else
            {
                var tempID = _employee.Position.ID;

                _employee.Position = new Position()
                {
                    ID = tempID,
                    EmployeeID = _employee.ID,
                    Post = (PositionModel)ComboBox_Position.SelectedItem,
                    Level = (LevelsPositionModel)ComboBox_LevelPosition.SelectedItem,
                    IsActual = true
                };

                _textBoxPosition.Text = _employee.Position.ToString();
                this.Close();
            }

        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox_Position.SelectedItem = _employee.Position.Post;
            ComboBox_LevelPosition.SelectedItem = _employee.Position.Level;
        }
    }
}
