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


        private void btnStart_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnOpt_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }
        private void btnEx_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnOpt_Click(object sender, RoutedEventArgs e)
        {

        }

        ElevenDays_GameServiceClient elevenDays_GameServiceClient;
        CallbackHandler callbackHandler = new CallbackHandler();
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            elevenDays_GameServiceClient = new ElevenDays_GameServiceClient(new System.ServiceModel.InstanceContext(callbackHandler));

            string game=elevenDays_GameServiceClient.CreateGame();
            if (elevenDays_GameServiceClient.StartByGameID(game, user))
            {
                WindowGame windowGame = new WindowGame(user,game);
                windowGame.Show();
                this.Close();
                //MenuSelectCharacter mSCh = new MenuSelectCharacter();
                //mSCh.Show();
                //this.Close();
            }
        }

    }
}
