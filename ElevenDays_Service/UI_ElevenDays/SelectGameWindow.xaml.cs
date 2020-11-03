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
    /// Логика взаимодействия для SelectGameWindow.xaml
    /// </summary>
    public partial class SelectGameWindow : Window
    {
        UserDTO userDTO;
        ElevenDays_GameServiceClient elevenDays_GameServiceClient = new ElevenDays_GameServiceClient();
        public SelectGameWindow(UserDTO userDTO)
        {
            InitializeComponent();
            this.userDTO = userDTO;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GameInfo[] gameInfos = elevenDays_GameServiceClient.GetGames(6);
            listBox.ItemsSource = gameInfos;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        string game = "";
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            game = elevenDays_GameServiceClient.CreateGame();

            if(elevenDays_GameServiceClient.StartByGameID(game, userDTO))
            {
                WindowGame gameWindow = new WindowGame(game, userDTO);
                gameWindow.Show();
                this.Close();
            }
        }
    }
}
