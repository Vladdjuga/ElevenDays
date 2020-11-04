using DLL_User;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
        public MediaPlayer soundPlay = new MediaPlayer();
        //UserDTO user = new UserDTO();
        public MenuEDs(/*UserDTO user*/)
        {
            InitializeComponent();
            soundPlay.Open(new Uri(@"Sound/Happy Three Friends.mp3", UriKind.Relative));
            soundPlay.Play();
            //this.user = user;
        }


        private void btnStart_MouseMove(object sender, MouseEventArgs e)
        {
            ImageBrush imB = new ImageBrush();
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri("Images/StartImEDs.png", UriKind.Relative);
            bit.EndInit();
            imB.Stretch = Stretch.Fill;
            imB.ImageSource = bit;
            grid.Background = imB;

            soundPlay.Open(new Uri(@"Sound/Scarry Voise to Start btn.mp3", UriKind.Relative));
            soundPlay.Volume = 0.05;
            soundPlay.Play();
        }

        private void btnOpt_MouseMove(object sender, MouseEventArgs e)
        {
            ImageBrush imB = new ImageBrush();
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri("Images/MenuOptions.png", UriKind.Relative);
            bit.EndInit();
            imB.Stretch = Stretch.Fill;
            imB.ImageSource = bit;
            grid.Background = imB;

            soundPlay.Open(new Uri(@"Sound/Voise to Option btn.mp3", UriKind.Relative));
            soundPlay.Volume = 0.5;
            soundPlay.Play();
        }
        private void btnEx_MouseMove(object sender, MouseEventArgs e)
        {
            ImageBrush imB = new ImageBrush();
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri("Images/ExitBackground.png", UriKind.Relative);
            bit.EndInit();
            imB.Stretch = Stretch.Fill;
            imB.ImageSource = bit;
            grid.Background = imB;

            soundPlay.Open(new Uri(@"Sound/Scary Voise to Exit btn.mp3", UriKind.Relative));
            soundPlay.Volume = 1;
            soundPlay.Play();
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
            this.Close();
            MenuSelectCharacter mSCh = new MenuSelectCharacter();
            mSCh.Show();
        }

    }
}
