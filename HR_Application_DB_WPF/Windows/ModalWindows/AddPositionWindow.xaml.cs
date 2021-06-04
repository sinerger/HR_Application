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

        public AddPositionWindow()
        {
            InitializeComponent();
            SetDataPosition(_position);
            SetDataLevelPosition(_levelPosition);
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
    }
}
