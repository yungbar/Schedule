using SchedulePlan.Base;
using SchedulePlan.BaseData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private Users users;

        private ScheduleEntities MyBase;
        public MainWindow(Users users)
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

            //Combobox для сортировки по статусу
            NameDepComboBox.ItemsSource = Core.BaseData.Status.ToList();


            UserNameLabel.Content = users.Name.ToString();

            //Обновление listbox
            RefershWindow();

            //Подгружаем фото пользователя
            //ImagePeople();
        }
        private void ObjectListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) // Нажатие на заказ
        {
            
            if (ObjectListBox.SelectedItem != null)
            {
                var selectedRequest = (Request)ObjectListBox.SelectedItem; // Получаем выбранный элемент
                AccountingWindow accountingWindow = new AccountingWindow(selectedRequest,users);
                accountingWindow.Show();
                Close();
            }
        }

        private void AddElementButton_Click(object sender, RoutedEventArgs e) // Создать заказ
        {
            AccountingWindow accountingWindow = new AccountingWindow(null,users);
            accountingWindow.Show();
            Close();
        }

        private void CloseWindowButton_Click_1(object sender, RoutedEventArgs e) // Выйти из аккаунта
        {
            Auth auth = new Auth();
            auth.Show();
            Close();
        }
        public void RefershWindow() //Отображение listbox в зависимости от прав 
        {
            switch (users.Root)
                {
                case 1:
                    ObjectListBox.ItemsSource = Core.BaseData.Request.Where(p => p.UserD == users.UserId).ToList();
                    break;
                case 3:

                    ObjectListBox.ItemsSource = Core.BaseData.Request.ToList();
                    break;
            }
        }

        private void NameDepComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) // обновляем conbobox
        {
            int status = NameDepComboBox.SelectedIndex + 1;
            ObjectListBox.ItemsSource = null;
            if (status == 0)
            {
                RefershWindow();
            }
            else
            {
                if (users.Root == 3)
                {
                    ObjectListBox.ItemsSource = Core.BaseData.Request.Where(p => p.SatusD == status).ToList();
                }
                else
                {
                    ObjectListBox.ItemsSource = Core.BaseData.Request.Where(p => p.SatusD == status && p.UserD == users.UserId).ToList();
                }
                
            }
        }

        private void ImagePeople()
        {
            string imagePath = users.LocationPicture;

            // Создаем объект BitmapImage и устанавливаем его как источник для Image
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();

            ImgPeople.Source = bitmapImage;
        }
    }
}
