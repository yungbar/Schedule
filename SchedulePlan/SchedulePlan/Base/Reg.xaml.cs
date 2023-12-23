using SchedulePlan.BaseData;
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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text !="" && PasswordTextBox.Password !="" && UserName.Text!="")
            {
                var AddObject = new Users();
                AddObject.Login = LoginTextBox.Text;
                AddObject.Password = PasswordTextBox.Password;
                AddObject.Root = 1;
                AddObject.Name = UserName.Text;
                Core.BaseData.Users.Add(AddObject);
                try
                {
                    Core.BaseData.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что то пошло не так вот ошибка: " + ex.Message);
                }
                Auth auth = new Auth();
                auth.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Введены не все поля для регистрации: ");
            }
            
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            Close();
        }
    }
}
