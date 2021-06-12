using HR_Application_BLL.Models;
﻿using HR_Application_DB_WPF.Classes;
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
    /// Interaction logic for Add_Competemce.xaml
    /// </summary>
    public partial class AddCompetenceWindow : Window
    {
        //=============>
        //=============>
        #region Заглушка данных
        // Заглушка данных.  в прод не пускать 
        private string[] tempSkills = new string[]
        {
            "C#",
            "java",
            "PHP",
            "Ruby",
            "JS"
        };
        private string[] tempLevelSkills = new string[]
        {
            "junior",
            "middle",
            "senior"
        };
        private string[] tempCountries = new string[]
        {
            "Ukraine",
            "Russia"
        };
        private string[] tempCities = new string[]
        {
            "Dnipro",
            "Kiev",
            "Moscow"
        };
        #endregion
        //=============>
        //=============>
        private Cache _cache;
        private int _height = 50;
        private int _widthComboBox = 200;
        private int _fontSize = 32;
        private string _backColorButton = "#E3405F";
        private string _contenAddButton = "+";
        private string _contenRemoveButton = "-";
        public List<Competence> competences = new List<Competence>();

        public AddCompetenceWindow()
        {
            InitializeComponent();
            CreateLineSkillStackPanel(new RoutedEventHandler(AddLineSkillStackPanelEvent),
                new RoutedEventHandler(RemoveLineStackPanelEvent));
            _cache = Cache.GetCache();
        }
        public AddCompetenceWindow(List<Competence> competencesFrom)
        {
            competences = competencesFrom;
        }

        private void SetSourceCompetences()
        {
            for (int i = 0; i < _cache.SelectedEmployee.Competences.Count; i++)
            {

            }
        }

        private void AddLineSkillStackPanelEvent(object sender, RoutedEventArgs e)
        {
            CreateLineSkillStackPanel(new RoutedEventHandler(AddLineSkillStackPanelEvent),
                new RoutedEventHandler(RemoveLineStackPanelEvent));
        }

        private void RemoveLineStackPanelEvent(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                var button = (Button)sender;
                if (button.Parent is StackPanel)
                {
                    var stackPanel = (StackPanel)button.Parent;
                    if (stackPanel.Parent is StackPanel)
                    {
                        var parentStackPanel = (StackPanel)stackPanel.Parent;
                        parentStackPanel.Children.Remove(stackPanel);
                    }
                }
            }
        }

        private void CreateLineSkillStackPanel(RoutedEventHandler addLineEvent, RoutedEventHandler removeLineEvent)
        {
            var stackPanel = GetStackPanel();

            stackPanel.Children.Add(GetButton(addLineEvent));
            stackPanel.Children.Add(GetComboBox(tempSkills));
            stackPanel.Children.Add(GetComboBox(tempLevelSkills));

            this.AllCompetenceStackPanel.Children.Add(stackPanel);

            SwitchAddButtonToRemoveButton(AllCompetenceStackPanel, addLineEvent, removeLineEvent);
        }

        private void SwitchAddButtonToRemoveButton(StackPanel currentStackPanel, RoutedEventHandler addLineEvent, RoutedEventHandler removeLineEvent)
        {

            for (int i = 0; i < currentStackPanel.Children.Count - 1; i++)
            {
                if (currentStackPanel.Children[i] is StackPanel)
                {
                    var mainStackPanel = (StackPanel)currentStackPanel.Children[i];
                    if (mainStackPanel.Children[0] is Button)
                    {
                        var tempButton = (Button)mainStackPanel.Children[0];
                        tempButton.Content = _contenRemoveButton;
                        tempButton.Click -= addLineEvent;
                        tempButton.Click += removeLineEvent;
                    }
                }
            }
        }

        private Button GetButton(RoutedEventHandler e)
        {
            Button button = new Button()
            {
                Height = _height,
                Width = _height,
                Content = _contenAddButton,
                FontSize = _fontSize,
                Background = (Brush)(new BrushConverter().ConvertFrom(_backColorButton)),
                Foreground = Brushes.White
            };

            button.Click += e;

            return button;
        }

        private ComboBox GetComboBox(string[] data)
        {
            ComboBox comboBox = new ComboBox()
            {
                Height = _height,
                Width = _widthComboBox,
                IsEditable = true,
                StaysOpenOnEdit = true
            };

            comboBox.ItemsSource = data;
            comboBox.FontSize = _fontSize;

            return comboBox;
        }

        private StackPanel GetStackPanel()
        {
            StackPanel stackPanel = new StackPanel();

            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Height = _height;

            return stackPanel;
        }

        private void Button_Accept_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Сохраняем компетенции у сотрудника

            this.Close();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
