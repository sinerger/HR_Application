using HR_Application_DB_WPF.ModalWindows;
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
    /// Interaction logic for EmployeeProfileHistory.xaml
    /// </summary>
    public partial class EmployeeProfileWindow : Window
    {
        public EmployeeProfileWindow()
        {
            InitializeComponent();
        }

        private void TabItem_MouseEnter(object sender, MouseEventArgs e)
        {
            var title = (TabItem)sender;
            title.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#E3405F"));
        }

        private void TabItem_MouseLeave(object sender, MouseEventArgs e)
        {
            var title = (TabItem)sender;
            title.Foreground =(SolidColorBrush)(new BrushConverter().ConvertFrom("#878383"));
        }

        private void TextBox_Department_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AddDepartmentWindow addDepartmentWindow = new AddDepartmentWindow();
            addDepartmentWindow.ShowDialog();
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

        private void Button_AddComment_Click(object sender, RoutedEventArgs e)
        {
            AddCommentWindow addCommentWindow = new AddCommentWindow();
            addCommentWindow.ShowDialog();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            //TODO:откат данных из модели Employee profile
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            //TODO:Сохранение данных в моделе Employee profile
            //this.Close();
        }
    }
}
