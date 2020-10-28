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
using UI_ElevenDays.ServiceReference1;

namespace UI_ElevenDays
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        User user = new User();
        PlayerInfo playerInfo;
        public GameWindow(DLL_User.User user)
        {
            InitializeComponent();
            this.user = user;

            ElevenDays_GameServiceClient elevenDays_ServiceClient = new ElevenDays_GameServiceClient();
            PlayerInfo pi = elevenDays_ServiceClient.Start(user);

            playerInfo = pi;

            Image image = new Image();
            image.Name = "player1";
            image.Height = playerInfo.Hitbox.Height;
            image.Width = playerInfo.Hitbox.Width;

            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(@"..\..\Images\banana.png", UriKind.Relative);
            bi3.EndInit();
            image.Stretch = Stretch.Fill;
            image.Source = bi3;

            (room.Content as Canvas).Children.Add(image);

            Binding binding = new Binding();
            binding.ElementName = "player1";
            binding.Path = new PropertyPath("Canvas.Left");
            binding.Source = playerInfo.Hitbox.StartPosition.X;

            image.SetBinding(Image.SourceProperty, binding);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D)
            {
                playerInfo.Hitbox.StartPosition=new PlayerCordons.Position(playerInfo.Hitbox.StartPosition.X+1, playerInfo.Hitbox.StartPosition.Y);
            }
        }
    }
}
