using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_WPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private int _height = 35;
        private int _widthComboBox = 200;
        private int _fontSize = 20;
        private string _backColorButton = "#E3405F";
        private string _contenAddButton = "+";
        private string _contenRemoveButton = "-";

        private Cache _cache;
        private Employee _employee;

        public AddCompetenceWindow(Employee employee)
        {
            _cache = Cache.GetCache();
            _employee = employee;

            InitializeComponent();
            if (_employee.Competences.Count > 0)
            {
                foreach (Competence competence in _employee.Competences)
                {
                    CreateLineSkillStackPanel(new RoutedEventHandler(AddLineSkillStackPanelEvent),
                        new RoutedEventHandler(RemoveLineStackPanelEvent), competence.Skill, competence.LevelSkill);
                }
            }
            else
            {
                CreateLineSkillStackPanel(new RoutedEventHandler(AddLineSkillStackPanelEvent),
                        new RoutedEventHandler(RemoveLineStackPanelEvent));
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

        private void CreateLineSkillStackPanel(RoutedEventHandler addLineEvent, RoutedEventHandler removeLineEvent,
            SkillModel currentSkill = null, LevelSkillModel currentLevelSkill = null)
        {
            var stackPanel = GetStackPanel();

            stackPanel.Children.Add(GetButton(addLineEvent));
            stackPanel.Children.Add(GetComboBoxSkill(_cache.Skills, currentSkill));
            stackPanel.Children.Add(GetComboBoxLevelSkill(_cache.LevelsSkills, currentLevelSkill));

            if (AllCompetenceStackPanel.Children.Count == 0)
            {
                this.AllCompetenceStackPanel.Children.Add(stackPanel);

                SwitchAddButtonToRemoveButton(AllCompetenceStackPanel, addLineEvent, removeLineEvent);
            }
            else if (AllCompetenceStackPanel.Children.Count > 0 && AllCompetenceStackPanel.Children[AllCompetenceStackPanel.Children.Count - 1] is StackPanel)
            {
                var lastStackPanel = (StackPanel)AllCompetenceStackPanel.Children[AllCompetenceStackPanel.Children.Count - 1];

                var firstomboBox = (ComboBox)lastStackPanel.Children[1];
                var secondComboBox = (ComboBox)lastStackPanel.Children[2];

                if (firstomboBox.SelectedItem != null && secondComboBox.SelectedItem != null)
                {
                    this.AllCompetenceStackPanel.Children.Add(stackPanel);

                    SwitchAddButtonToRemoveButton(AllCompetenceStackPanel, addLineEvent, removeLineEvent);
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
                Content = _contenAddButton,
                FontSize = _fontSize,
                Background = (Brush)(new BrushConverter().ConvertFrom(_backColorButton)),
                Foreground = Brushes.White
            };

            button.Click += e;

            return button;
        }

        private ComboBox GetComboBoxSkill(List<SkillModel> skills, SkillModel currentSkill = null)
        {
            ComboBox comboBox = new ComboBox()
            {
                Height = _height,
                Width = _widthComboBox,
                IsEditable = true,
                StaysOpenOnEdit = true
            };

            comboBox.ItemsSource = skills;
            comboBox.SelectedItem = currentSkill != null ? currentSkill : null;
            comboBox.FontSize = _fontSize;

            return comboBox;
        }

        private ComboBox GetComboBoxLevelSkill(List<LevelSkillModel> levelsSkills, LevelSkillModel currentLevelskill = null)
        {
            ComboBox comboBox = new ComboBox()
            {
                Height = _height,
                Width = _widthComboBox,
                IsEditable = true,
                StaysOpenOnEdit = true
            };

            comboBox.ItemsSource = levelsSkills;
            comboBox.SelectedItem = currentLevelskill != null ? currentLevelskill : null;
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
            List<Competence> competences = new List<Competence>();

            for (int i = 0; i < AllCompetenceStackPanel.Children.Count; i++)
            {
                if (AllCompetenceStackPanel.Children[i] is StackPanel)
                {
                    var stackPanel = (StackPanel)AllCompetenceStackPanel.Children[i];

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
                                EmployeeID = _employee.ID,
                                Skill = (SkillModel)comboBoxSkill.SelectedItem,
                                LevelSkill = (LevelSkillModel)comboBoxLevelSkill.SelectedItem
                            });
                        }
                    }
                }
            }

            for (int i = 0; i < competences.Count; i++)
            {
                if (i < _employee.Competences.Count)
                {
                    _employee.Competences[i].Skill = competences[i].Skill.Clone();
                    _employee.Competences[i].LevelSkill = competences[i].LevelSkill.Clone();
                }
                else
                {
                    _employee.Competences.Add(competences[i].Clone());
                }
            }

            var competencesString = string.Empty;

            foreach (Competence competence in _employee.Competences)
            {
                competencesString += $"{competence.ToString()}\n";
            }

            this.Close();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
