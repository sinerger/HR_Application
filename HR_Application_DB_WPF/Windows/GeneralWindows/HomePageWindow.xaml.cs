using HR_Application_BLL.Models;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_WPF.Classes;
using HR_Application_DB_WPF.ModalWindows;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomePageWindow : Window
    {
        public class EmployeeTest
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string RegistrationDate { get; set; }
            public GeneralInformationModel GeneralInformation { get; set; }
            public Department Department { get; set; }
            public PositionModel Position { get; set; }
            public List<Competence> Competence { get; set; }
            public ProjectModel Project { get; set; }
            public List<CommentModel> Comments { get; set; }
            public EmployeeTest()
            {
                ID = 1;
                FirstName = "aaa";
                LastName = "qqq";
                RegistrationDate = "20.12.2019";
                GeneralInformation = new GeneralInformationModel()
                {
                    ID = 1,
                    EmployeeID = 1,
                    FamilyStatusID = 1,
                    Education = "Hight",
                    Hobby = "Swimming",
                    Sex = "Male",
                    AmountChildren = 0,
                    BirthDate = "20.02.1989",
                    Phone = "+380632581254",
                    Email = "Goga@gmail.com"
                };
                Department = new Department()
                {
                    ID = 1,
                    Title = "RoR",
                    Description = "Description",
                    Projects = new List<ProjectModel>()
                };
                Position = new PositionModel()
                {
                    ID =1,
                    Title = "Middle",
                    Description = "Description"
                };
                Competence = new List<Competence>()
                {
                    new Competence()
                    {
                        Skill = new SkillModel(){ID = 1, Title = "C#", Description = "blabla"},
                        LevelSkill = new LevelSkillModel(){ ID = 1, Title = "Base"}
                    },
                    new Competence()
                    {
                        Skill = new SkillModel(){ID = 1, Title = "RoR", Description = "blabla2"},
                        LevelSkill = new LevelSkillModel(){ID = 2, Title = "God"}
                    }
                };
                Project = new ProjectModel()
                {
                    ID = 1,
                    Title = "EconomicSystem",
                    Description = "Description",
                    DirectionID = 2
                };
                Comments = new List<CommentModel>()
                {
                    new CommentModel()
                    {
                        Information = "Good employee with perfect soft skills",
                        Date = "20.11.2020"
                    },
                    new CommentModel()
                    {
                        Information = "Nice Bro with strong hard skills",
                        Date = "20.01.2020"
                    }
                };

            }
        }

        private Cache _cache;

        public HomePageWindow()
        {
            InitializeComponent();
            _cache = Cache.GetCache();
            EmployeeTest employee = new EmployeeTest();
            DataContext = employee;

            InitializeUserData();

            DataGrid_Employees.ItemsSource = new List<EmployeeTest>()
            {
                new EmployeeTest()
                {
                    ID = 1,
                    FirstName = "aaa",
                    LastName = "qqq",
                    RegistrationDate = "20.12.2019"
                }
            };
        }

        private void InitializeUserData()
        {
            TextBox_Name.Text = $"{_cache.CurrentUser.FirstName} {_cache.CurrentUser.LastName}";
            TextBox_Company.Text = _cache.CurrentUser.Company.ToString();
            TextBox_City.Text = _cache.CurrentUser.Company.Adress.City.ToString();
        }

        private void DataGridCell_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            // TODO: Запретить редактирование ячеек в таблицах 
        }

        private void Button_OpenFilterWindow_Click(object sender, RoutedEventArgs e)
        {
            FilterWindow filter = new FilterWindow();
            filter.ShowDialog();
        }

        private void Button_ClearFilter_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Очистка фильтра
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Поиск сотрудников по фильтру
        }


        private void Button_LogOut_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Убрать пользователя 

            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();

            this.Close();
        }

        private void Button_ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow();
            changePasswordWindow.ShowDialog();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Сохранить изменение данных пользователя 
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Отменить изменения данных пользователя
        }

        private void Button_AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.ShowDialog();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_SaveUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_Company_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var AddDepWindow = new AddDepartmentWindow((TextBox)sender);

            AddDepWindow.ShowDialog();
        }

        private void TextBox_Company_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (_cache.SelectedCompany != null)
            {
                TextBox_City.Text = _cache.SelectedCompany.ToString();
            }
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (!(DataGrid_Employees.SelectedItem is null))
            {
                //_cache.SelectedEmployee = DataGrid_Employees.SelectedItem as Employee;
                EmployeeTest employee = DataGrid_Employees.SelectedItem as EmployeeTest;
                EmployeeProfileWindow editEmployeeWindow = new EmployeeProfileWindow(employee);
                editEmployeeWindow.ShowDialog();
            }
        }
    }
}
