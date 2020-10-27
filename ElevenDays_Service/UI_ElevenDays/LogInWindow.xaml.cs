using DLL_User;
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

namespace UI_ElevenDays
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model_Users model_Users;
        public MainWindow()
        {
            InitializeComponent();
            model_Users = new Model_Users();
            model_Users.Users.Any();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            RegisterWindow registerWindow = new RegisterWindow(model_Users);
            if (registerWindow.ShowDialog() == true)
            {
                MessageBox.Show("Success registration!");
            }
            this.Visibility=Visibility.Visible;
        }
    }
}
