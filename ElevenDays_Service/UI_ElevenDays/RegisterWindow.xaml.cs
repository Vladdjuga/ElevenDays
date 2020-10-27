using DLL_User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
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

namespace UI_ElevenDays
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        Model_Users model_Users;
        public RegisterWindow(Model_Users model_Users)
        {
            InitializeComponent();
            this.model_Users = model_Users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                model_Users.Users.Add(new User() { Login = tbLogin.Text, Email = tbEmail.Text, PasswordHash = Model_Users.GetHash(SHA256.Create(), pbPassword.Password) });
                model_Users.SaveChanges();
                DialogResult = true;
            }
            catch(Exception ex) { MessageBox.Show("Try again!"); }
        }
    }
}
