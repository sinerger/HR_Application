using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_WPF.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {

        private int _height = 50;
        private int _widthComboBox = 200;
        private int _fontSize = 20;
        private string _backColorButton = "#E3405F";
        private string _contenAddButton = "+";
        private string _contenRemoveButton = "-";

        private Cache _cache;
        private Filter _filter;

        public FilterWindow(Filter filter = null)
        {
            _cache = Cache.GetCache();
            if (filter != null)
            {
                _filter = filter;
            }
            else
            {
                _filter = new Filter();
            }

            InitializeComponent();

            CreateLineSkillStackPanel(new RoutedEventHandler(AddLineSkillStackPanelEvent),
                new RoutedEventHandler(RemoveLineStackPanelEvent));

            CreateLineAdressStackPanel(new RoutedEventHandler(AddLineAdressStackPanelEvent),
                new RoutedEventHandler(RemoveLineStackPanelEvent));
        }

        private void AddLineSkillStackPanelEvent(object sender, RoutedEventArgs e)
        {
            CreateLineSkillStackPanel(new RoutedEventHandler(AddLineSkillStackPanelEvent),
                new RoutedEventHandler(RemoveLineStackPanelEvent));
        }

        private void AddLineAdressStackPanelEvent(object sender, RoutedEventArgs e)
        {
            CreateLineAdressStackPanel(new RoutedEventHandler(AddLineAdressStackPanelEvent),
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

        private void CreateLineSkillStackPanel(RoutedEventHandler addLineEvent, RoutedEventHandler removeLineEvent,
            SkillModel currentSkill = null, LevelSkillModel currentLevelSkill = null)
        {
            var stackPanel = GetStackPanel();

            stackPanel.Children.Add(GetButton(addLineEvent));
            stackPanel.Children.Add(GetComboBoxSkill(_cache.Skills, currentSkill));
            stackPanel.Children.Add(GetComboBoxLevelSkill(_cache.LevelsSkills, currentLevelSkill));

            if (AllSkillsStackPanel.Children.Count == 0)
            {
                this.AllSkillsStackPanel.Children.Add(stackPanel);

                SwitchAddButtonToRemoveButton(AllSkillsStackPanel, addLineEvent, removeLineEvent);
            }
            else if (AllSkillsStackPanel.Children.Count > 0 && AllSkillsStackPanel.Children[AllSkillsStackPanel.Children.Count - 1] is StackPanel)
            {
                var lastStackPanel = (StackPanel)AllSkillsStackPanel.Children[AllSkillsStackPanel.Children.Count - 1];

                var firstomboBox = (ComboBox)lastStackPanel.Children[1];
                var secondComboBox = (ComboBox)lastStackPanel.Children[2];

                if (firstomboBox.SelectedItem != null && secondComboBox.SelectedItem != null)
                {
                    this.AllSkillsStackPanel.Children.Add(stackPanel);

                    SwitchAddButtonToRemoveButton(AllSkillsStackPanel, addLineEvent, removeLineEvent);
                }
            }
        }

        private void CreateLineAdressStackPanel(RoutedEventHandler addLineEvent, RoutedEventHandler removeLineEvent,
            CityModel currentCity = null, Department currentDepartment = null)
        {
            var stackPanel = GetStackPanel();

            stackPanel.Children.Add(GetButton(addLineEvent));
            stackPanel.Children.Add(GetComboBoxCity(_cache.Cities, currentCity));
            //stackPanel.Children.Add(GetComboBoxDepartment(_cache.Departments, currentDepartment));

            if (AllAdressStackPanel.Children.Count == 0)
            {
                this.AllAdressStackPanel.Children.Add(stackPanel);

                SwitchAddButtonToRemoveButton(AllAdressStackPanel, addLineEvent, removeLineEvent);
            }
            else if (AllAdressStackPanel.Children.Count > 0 && AllAdressStackPanel.Children[AllAdressStackPanel.Children.Count - 1] is StackPanel)
            {
                var lastStackPanel = (StackPanel)AllAdressStackPanel.Children[AllAdressStackPanel.Children.Count - 1];

                var firstomboBox = (ComboBox)lastStackPanel.Children[1];
                //var secondComboBox = (ComboBox)lastStackPanel.Children[2];

                if (firstomboBox.SelectedItem != null /*|| secondComboBox.SelectedItem != null*/)
                {
                    this.AllAdressStackPanel.Children.Add(stackPanel);

                    SwitchAddButtonToRemoveButton(AllAdressStackPanel, addLineEvent, removeLineEvent);
                }
            }
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
                Content = "+",
                FontSize = _fontSize,
                Background = (Brush)(new BrushConverter().ConvertFrom(_backColorButton)),
                Foreground = Brushes.White
            };

            button.Click += e;

            return button;
        }

        private ComboBox GetComboBox()
        {
            ComboBox comboBox = new ComboBox()
            {
                Height = _height,
                Width = _widthComboBox,
                IsEditable = true,
                StaysOpenOnEdit = true
            };

            comboBox.FontSize = _fontSize;

            return comboBox;
        }

        private ComboBox GetComboBoxSkill(List<SkillModel> skills, SkillModel currentSkill = null)
        {
            ComboBox comboBox = GetComboBox();

            comboBox.ItemsSource = skills;
            comboBox.SelectedItem = currentSkill != null ? currentSkill : null;

            return comboBox;
        }

        private ComboBox GetComboBoxLevelSkill(List<LevelSkillModel> levelsSkills, LevelSkillModel currentLevelskill = null)
        {
            ComboBox comboBox = GetComboBox();

            comboBox.ItemsSource = levelsSkills;
            comboBox.SelectedItem = currentLevelskill != null ? currentLevelskill : null;

            return comboBox;
        }

        private ComboBox GetComboBoxCity(List<CityModel> cities, CityModel currentCity = null)
        {
            ComboBox comboBox = GetComboBox();

            comboBox.ItemsSource = cities;
            comboBox.SelectedItem = currentCity != null ? currentCity : null;

            return comboBox;
        }

        private ComboBox GetComboBoxDepartment(List<Department> departments, Department department = null)
        {
            ComboBox comboBox = GetComboBox();

            comboBox.ItemsSource = departments;
            comboBox.SelectedItem = department != null ? department : null;

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
            List<Competence> competences = new List<Competence>();

            for (int i = 0; i < AllSkillsStackPanel.Children.Count; i++)
            {
                if (AllSkillsStackPanel.Children[i] is StackPanel)
                {
                    var stackPanel = (StackPanel)AllSkillsStackPanel.Children[i];

                    if (stackPanel.Children[1] is ComboBox && stackPanel.Children[2] is ComboBox)
                    {
                        var comboBoxSkill = (ComboBox)stackPanel.Children[1];
                        var comboBoxLevelSkill = (ComboBox)stackPanel.Children[2];

                        var skill = (SkillModel)comboBoxSkill.SelectedItem;
                        var levelSkill = (LevelSkillModel)comboBoxLevelSkill.SelectedItem;
                        if (skill != null && levelSkill != null)
                        {
                            competences.Add(new Competence()
                            {
                                Skill = (SkillModel)comboBoxSkill.SelectedItem,
                                LevelSkill = (LevelSkillModel)comboBoxLevelSkill.SelectedItem
                            });
                        }
                    }
                }
            }

            List<CityModel> cities = new List<CityModel>();
            List<Department> departments = new List<Department>();

            for (int i = 0; i < AllAdressStackPanel.Children.Count; i++)
            {
                if (AllAdressStackPanel.Children[i] is StackPanel)
                {
                    var stackPanel = (StackPanel)AllAdressStackPanel.Children[i];

                    if (stackPanel.Children[1] is ComboBox /*&& stackPanel.Children[2] is ComboBox*/)
                    {
                        var comboBoxCity = (ComboBox)stackPanel.Children[1];
                        //var comboBoxDepartment = (ComboBox)stackPanel.Children[2];

                        var city = (CityModel)comboBoxCity.SelectedItem;
                        //var department = (Department)comboBoxDepartment.SelectedItem;

                        if (city != null)
                        {
                            cities.Add(city);
                        }
                        //if (department != null)
                        //{
                        //    departments.Add(department);
                        //}
                    }
                }
            }

            _filter.Competences = competences.Count>0?competences:null;
            _filter.Cities = cities.Count>0?cities:null;
            _filter.Departments = departments.Count>0?departments:null;

            this.Close();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
