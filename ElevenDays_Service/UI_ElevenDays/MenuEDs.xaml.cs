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
using System.Windows.Shapes;
using UI_ElevenDays.ServiceReference2;

namespace UI_ElevenDays
{
    /// <summary>
    /// Логика взаимодействия для MenuEDs.xaml
    /// </summary>
    public partial class MenuEDs : Window
    {
        UserDTO user = new UserDTO();
        public MenuEDs(UserDTO user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnOpt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //this.Visibility = Visibility.Collapsed;

            /*WindowGame gameWindow = new WindowGame(user);
            if (gameWindow.ShowDialog() == true)
            {

            }*/

            //this.Visibility = Visibility.Visible;
            /*this.Visibility = Visibility.Collapsed;
            MenuSelectCharacter mSCh = new MenuSelectCharacter();
            if (mSCh.ShowDialog() == true)
            {
                MessageBox.Show("Success registration!");
            }
            mSCh.Visibility = Visibility.Visible;*/
            SelectGameWindow selectGameWindow = new SelectGameWindow(user);
            selectGameWindow.Show();
            this.Close();
            //MenuSelectCharacter mSCh = new MenuSelectCharacter();
            //mSCh.Show();
        }
    }
}
