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
    /// Логика взаимодействия для WindowGame.xaml
    /// </summary>
    public partial class WindowGame : Window
    {
        string game = "";
        UserDTO userDTO;
        public WindowGame(string game, UserDTO userDTO)
        {
            InitializeComponent();

            tbGame.Text = game;
            this.userDTO = userDTO;

            ElevenDays_GameServiceClient elevenDays_GameServiceClient = new ElevenDays_GameServiceClient();
            lbPlayers.ItemsSource = elevenDays_GameServiceClient.GetPlayersByGameID(game);
        }
    }
}
