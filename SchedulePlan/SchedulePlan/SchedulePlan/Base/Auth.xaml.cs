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
using System.Windows.Shapes;

namespace SchedulePlan.Base
{
    /// <summary>
    /// Interaction logic for Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        private Base.ScheduleEntities Schedule;
        private int cnt = 0; 

        public Auth()
        {
            InitializeComponent();
            try
            {
                Schedule = new Base.ScheduleEntities();
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к базе", "Предупреждение", MessageBoxButton.OK);
            }
            RowCaptcha.Height = new GridLength(0);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Base.Users users = Core.BaseData.Users.FirstOrDefault(R => R.Login == LoginTextBox.Text && R.Password == PasswordTextBox.Text);
            if (users != null)
            {
                if (cnt == 0 || CaptchaTextBoxForUser.Text == CaptchaTextBox.Text)
                {
                    MainWindow mainWindow= new MainWindow(users);
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Не верная капча", "Предупреждение", MessageBoxButton.OK);
                }

            }
            else
            {
                CaptchaTextBox.Text = "";
                cnt++;
                RowCaptcha.Height = new GridLength(100);
                char[] captchaname = { 'a', 'b', 'c', 'd', 'e' };
                Random rnd = new Random();
                for (int leng = 0; leng < 4; leng++)
                {
                    CaptchaTextBox.Text += captchaname[rnd.Next(1, 5)];
                }
                MessageBox.Show("Пользователь не найден", "Предупреждение", MessageBoxButton.OK);
            }
        }
    }
}
