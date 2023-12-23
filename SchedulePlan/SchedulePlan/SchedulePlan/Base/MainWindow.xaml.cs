using SchedulePlan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchedulePlan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Base.ScheduleEntities Schedule;
        private Base.Users user;
        private Base.Request request;

        public MainWindow(Base.Users users)
        {
            InitializeComponent();
            try
            {
                Schedule = new Base.ScheduleEntities();
            }
            catch
            {
                MessageBox.Show("Подключение к бд не произвдено", "предупреждение", MessageBoxButton.OK);

            }
            this.user = user;


            ObjectListBox.ItemsSource = Core.BaseData.Request.ToList();

            RefershWindow();
        }

        private void Visible()
        {
            
        }
        private void ObjectListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var ShecdulePlan = new Base.Request();
            ShecdulePlan = (Base.Request)ObjectListBox.SelectedItem;
        }

        private void AddElementButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseWindowButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CloseWindowButton_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void RefershWindow()
        {
            ObjectListBox.ItemsSource = Core.BaseData.Users.ToList();
        }
    }
}
