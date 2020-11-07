using DLL_User;
using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI_ElevenDays.ServiceReference2;

namespace UI_ElevenDays
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            elevenDays_GameServiceClient = new ElevenDays_GameServiceClient(new System.ServiceModel.InstanceContext(callbackHandler));
        }

        CallbackHandler callbackHandler = new CallbackHandler();
        ElevenDays_GameServiceClient elevenDays_GameServiceClient;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;

            UserDTO userDTO = elevenDays_GameServiceClient.Login(tbEmail.Text, tbPassword.Password);
            if (userDTO != null)
            {
                MenuEDs menuWindow = new MenuEDs(userDTO);
                menuWindow.Show();
                this.Close();
                return;
            }
            this.Visibility = Visibility.Visible;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            RegisterWindow registerWindow = new RegisterWindow();
            if (registerWindow.ShowDialog() == true)
            {
                MessageBox.Show("Success registration!");
            }
            this.Visibility=Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
