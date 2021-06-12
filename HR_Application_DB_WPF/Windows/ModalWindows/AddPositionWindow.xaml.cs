using HR_Application_BLL.Base.Models;
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
        //=============>
        //=============>
        #region Загушка Данных
        private string[] _position = new string[]
        {
            "Dev",
            "QA",
            "Disigner"
        };
        private string[] _levelPosition = new string[]
        {
            "1",
            "2",
            "3"
        };

        #endregion
        //=============>
        //=============>
        private Cache _cache;
        private Position _positionEmployee;

        public AddPositionWindow()
        {
            InitializeComponent();
            SetDataPosition(_position);
            SetDataLevelPosition(_levelPosition);
            _cache = Cache.GetCache();
            _positionEmployee = _cache.SelectedPositionEmployee;
        }

        public AddPositionWindow(Position fromEmployee)
        {
            _positionEmployee = fromEmployee;
            InitializeComponent();
        }

        public void SetDataPosition(string[] positions)
        {
            PositionComboBox.ItemsSource = positions;
        }

        public void SetDataLevelPosition(string[] levelsPosition)
        {
            LevelPositionComboBox.ItemsSource = levelsPosition;
        }

        private void Button_Accept_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Сохраняем данные что ввели для сотрудника

            this.Close();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PositionComboBox.SelectedItem = _positionEmployee.Post;
            LevelPositionComboBox.SelectedItem = _positionEmployee.Level;
        }
    }
}
