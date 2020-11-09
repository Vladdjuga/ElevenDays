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
        CallbackHandler callback = new CallbackHandler();
        ElevenDays_GameServiceClient elevenDays_GameServiceClient;
        public SelectGameWindow(UserDTO userDTO)
        {
            InitializeComponent();
            this.userDTO = userDTO;
            elevenDays_GameServiceClient = new ElevenDays_GameServiceClient(new System.ServiceModel.InstanceContext(callback));

            SetGames();
        }

        private void SetGames()
        {
            List<GameInfo> gameInfos = new List<GameInfo>();
            for (int i = 0; i < elevenDays_GameServiceClient.GetGamesCount(); i++)
            {
                gameInfos.Add(elevenDays_GameServiceClient.GetGame(i));
            }
            listBox.ItemsSource = gameInfos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetGames();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (elevenDays_GameServiceClient.FindGameById(tbCode.Text)!=null)
            {
                MenuSelectCharacter gameWindow = new MenuSelectCharacter(userDTO, tbCode.Text);
                gameWindow.Show();
                this.Close();
            }
        }

        string game = "";

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            game = elevenDays_GameServiceClient.CreateGame();

            if (elevenDays_GameServiceClient.FindGameById(game) != null)
            {
                MenuSelectCharacter gameWindow = new MenuSelectCharacter(userDTO, game);
                gameWindow.Show();
                this.Close();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string start = elevenDays_GameServiceClient.FindGame();
            if (start != "")
            {
                MenuSelectCharacter gameWindow = new MenuSelectCharacter(userDTO, start);
                gameWindow.Show();
                this.Close();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {

                GameInfo gameInfo = listBox.SelectedItem as GameInfo;

                if (elevenDays_GameServiceClient.FindGameById(gameInfo.Id) != null)
                {
                    MenuSelectCharacter gameWindow = new MenuSelectCharacter(userDTO, gameInfo.Id);
                    gameWindow.Show();
                    this.Close();
                }
            }
        }
        private void WindowToolsControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void WindowToolsControl_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Maximized == this.WindowState ? WindowState.Normal : WindowState.Maximized;
        }

        private void WindowToolsControl_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
