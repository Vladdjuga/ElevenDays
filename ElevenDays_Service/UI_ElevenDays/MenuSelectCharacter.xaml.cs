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
    /// Логика взаимодействия для MenuSelectCharacter.xaml
    /// </summary>
    public partial class MenuSelectCharacter : Window
    {
        private UserDTO user;
        private string game;

        ElevenDays_GameServiceClient elevenDays_GameServiceClient;
        CallbackHandler callback = new CallbackHandler();

        public MenuSelectCharacter(UserDTO userDTO,string game)
        {
            InitializeComponent();
            user = userDTO;
            this.game = game;

            elevenDays_GameServiceClient = new ElevenDays_GameServiceClient(new System.ServiceModel.InstanceContext(callback));

            foreach (var item in grid.Children)
            {
                if(item is Border)
                {
                    (item as Border).IsEnabled = !elevenDays_GameServiceClient.IsAnyWithFruit(game, (item as Border).Tag.ToString());
                    if (!(item as Border).IsEnabled)
                        (item as Border).Opacity = 0.5;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowGame windowGame = new WindowGame(user,game,(sender as Border).Tag.ToString());
            windowGame.Show();
            this.Close();
        }
    }
}
