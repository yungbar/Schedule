using SchedulePlan.BaseData;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
using System.Windows.Shapes;
using SchedulePlan.Base;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace SchedulePlan.Base
{
    /// <summary>
    /// Логика взаимодействия для AccountingWindow.xaml
    /// </summary>
    public partial class AccountingWindow : Window
    {
        private ScheduleEntities MyBase;
        private Request request;
        private Users users;
        public AccountingWindow(Request request, Users users)
        {
            InitializeComponent();

            try
            {
                MyBase = new ScheduleEntities();
                DataContext = Core.BaseData;
            }
            catch
            {
                MessageBox.Show("Подключение к бд не произвдено", "предупреждение", MessageBoxButton.OK);

            }
            
            this.users = users;
            this.request = request;
            ProductNameComboBox.ItemsSource = Core.BaseData.Product.ToList();
            StatusComboBox.ItemsSource = Core.BaseData.Status.ToList();

            if (users.Root == 3)
            {
                StatusText.Visibility = Visibility.Visible;
                StatusComboBox.Visibility = Visibility.Visible;
            }
            else
            {
                StatusText.Visibility = Visibility.Hidden;
                StatusComboBox.Visibility = Visibility.Hidden;
            }

            if (request != null)
            {
                DeleteButton.Visibility = Visibility.Visible;
                ProductNameComboBox.SelectedItem = request.Product;
                CountTextBox.Text = request.Number.ToString();
                CommentTextBox.Text = request.Comment.ToString();
                SaveChangeButton.Content = "Редактировать";
            }
            else
            {
                DeleteButton.Visibility = Visibility.Hidden;
                SaveChangeButton.Content = "Заказ";
            }
        }

        private void SaveChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (request != null)
            {

                request = Core.BaseData.Request.FirstOrDefault(P => P.RequestId == request.RequestId);
                request.DataD = ProductNameComboBox.SelectedIndex + 1;
                request.Number = CountTextBox.Text;
                if (users.Root == 3)
                {
                    if (StatusComboBox.SelectedIndex > 0) 
                        request.SatusD = StatusComboBox.SelectedIndex+1; 
                    else request.SatusD = 1;
                }
                else
                {
                    request.SatusD = 1;
                }
                request.Comment = CommentTextBox.Text;
            }
            else
            {
                var AddObject = new SchedulePlan.Request();
                AddObject.RequestId = Core.BaseData.Request.Max(p => p.RequestId)+1;
                AddObject.DataD = ProductNameComboBox.SelectedIndex+1;
                AddObject.Number = CountTextBox.Text;
                AddObject.UserD = users.UserId;
                if (users.Root == 3)
                {
                    if (StatusComboBox.SelectedIndex > 0)
                        AddObject.SatusD  = StatusComboBox.SelectedIndex+1;
                    else AddObject.SatusD = 1;
                }
                else
                {
                    AddObject.SatusD = 1;
                }
                
                AddObject.Comment = CommentTextBox.Text;
                Core.BaseData.Request.Add(AddObject);
            }
            try
            {
                Core.BaseData.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что то пошло не так вот ошибка: "+ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            MainWindow mainWindow = new MainWindow(users);
            mainWindow.Show();
            Close();
        }

        private void CancelChangeButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(users);
            mainWindow.Show();
            Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Внимание", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                try
                {
                    Core.BaseData.Request.Remove(request);
                    Core.BaseData.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Прикол: {ex}", "Внимание", MessageBoxButton.OK);
                }
                MainWindow mainWindow = new MainWindow(users);
                mainWindow.Show();
                Close();
            }
        }
    }
}
