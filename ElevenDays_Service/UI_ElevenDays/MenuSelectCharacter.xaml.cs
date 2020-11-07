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

        public MenuSelectCharacter(UserDTO userDTO,string game)
        {
            InitializeComponent();
            user = userDTO;
            this.game = game;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowGame windowGame = new WindowGame(user,game,(sender as Border).Tag.ToString());
            windowGame.Show();
            this.Close();
        }
    }
}
