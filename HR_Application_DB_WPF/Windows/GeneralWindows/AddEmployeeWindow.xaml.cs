﻿using HR_Application_DB_WPF.ModalWindows;
using HR_Application_DB_WPF.Windows.ModalWindows;
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

namespace HR_Application_DB_WPF.Windows.GeneralWindows
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();
        }

        private void TextBox_Department_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void TextBox_Department_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddDepartmentWindow addDepartment = new AddDepartmentWindow();
            addDepartment.ShowDialog();
        }

        private void TextBox_Position_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddPositionWindow addPositionWindow = new AddPositionWindow();
            addPositionWindow.ShowDialog();
        }

        private void TextBox_Competence_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddCompetenceWindow addCompetenceWindow = new AddCompetenceWindow();
            addCompetenceWindow.ShowDialog();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Добавляем нового сотрудника
            this.Close();
        }
    }
}