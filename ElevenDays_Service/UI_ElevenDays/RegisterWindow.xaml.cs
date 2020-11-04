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
using UI_ElevenDays.ServiceReference2;

namespace UI_ElevenDays
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        CallbackHandler callbackHandler = new CallbackHandler();
        ElevenDays_GameServiceClient elevenDays_GameServiceClient;
        public RegisterWindow()
        {
            InitializeComponent();

            elevenDays_GameServiceClient = new ElevenDays_GameServiceClient(new System.ServiceModel.InstanceContext(callbackHandler));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool v = elevenDays_GameServiceClient.Register(tbLogin.Text, tbEmail.Text, pbPassword.Password);

                if (!v)
                    MessageBox.Show("This login are already exists!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                else
                DialogResult = v;
            }
            catch(Exception ex) { MessageBox.Show("Try again!"); }
        }
    }
}
