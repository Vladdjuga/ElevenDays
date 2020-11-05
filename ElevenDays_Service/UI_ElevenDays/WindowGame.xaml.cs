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
using UI_ElevenDays.Controls;
using UI_ElevenDays.ServiceReference2;

namespace UI_ElevenDays
{
    /// <summary>
    /// Логика взаимодействия для WindowGame.xaml
    /// </summary>
    public partial class WindowGame : Window
    {
        ElevenDays_GameServiceClient elevenDays_GameServiceClient;
        CallbackHandler callback = new CallbackHandler();

        FruitControl fruitControl;
        List<FruitControl> fruitControls = new List<FruitControl>();

        UserDTO user;
        string game;

        public WindowGame(UserDTO user, string game)
        {
            InitializeComponent();

            tbCode.Text = game;

            callback.Count=100;

            callback.DisconnectedEvent += Callback_DisconnectedEvent;
            callback.StateEvent += Callback_StateEvent;
            callback.MoveEvent += Callback_MoveEvent;
            callback.NewPlayerArrivedEvent += Callback_NewPlayerArrivedEvent;

            elevenDays_GameServiceClient = new ElevenDays_GameServiceClient(new System.ServiceModel.InstanceContext(callback));

            elevenDays_GameServiceClient.StartByGameID(game, user);

            this.user = user;
            this.game = game;

            for (int i = 0; i < elevenDays_GameServiceClient.GetPlayersCount(game); i++)
            {
                string str = elevenDays_GameServiceClient.GetPlayerString(game, i);
                if(str!=user.Login)
                Callback_NewPlayerArrivedEvent(new Position() { X = 0, Y = 0 }, str);
            }

            fruitControl = new FruitControl("Images/BananaCh2.png",new Position() { X=0, Y=0 },user.Login);
            fruitControl.Tag = user.Login;

            canvas.Children.Add(fruitControl);
        }



        private void Callback_DisconnectedEvent(string login)
        {
            FruitControl fruitControl = fruitControls.First(el => el.Tag.ToString() == login);

            canvas.Children.Remove(fruitControl);
            fruitControls.Remove(fruitControl);
        }

        private void Callback_StateEvent(string state, string login)
        {
            FruitControl fruitControl = fruitControls.First(el => el.Tag.ToString() == login);

            string img="";
            if (state == "StayRight")
                img = "Images/BananaCh2.png";
            if(state=="StayLeft")
                img = "Images/BananaCh1.png";

            fruitControl.imgBrush.ImageSource = new BitmapImage(new Uri(img, UriKind.Relative));
        }

        private void Callback_NewPlayerArrivedEvent(Position position, string login)
        {
            FruitControl fruitControl = new FruitControl("Images/BananaCh2.png", position,login);
            fruitControl.Tag = login;

            canvas.Children.Add(fruitControl);
            fruitControls.Add(fruitControl);
        }

        private void Callback_MoveEvent(Position position, string login)
        {
            FruitControl fruitControl = fruitControls.First(el => el.Tag.ToString() == login);

            Canvas.SetLeft(fruitControl, position.X);
            Canvas.SetTop(fruitControl, position.Y);
        }

        string state = "";
        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            int left = 0, top = 0;

            Task.Run(() =>
            {
                if (e.Key == Key.Up)
                {
                    top -= 10;
                }
                if (e.Key == Key.Down)
                {
                    top += 10;
                }
                if (e.Key == Key.Left)
                {
                    left -= 10;
                    state = "StayLeft";
                }
                if (e.Key == Key.Right)
                {
                    left += 10;
                    state = "StayRight";
                }
            }).Wait();

            //elevenDays_GameServiceClient.ChangePlayerState(game, user.Login, state);

            string img = "";
            if (state == "StayRight")
                img = "Images/BananaCh2.png";
            if (state == "StayLeft")
                img = "Images/BananaCh1.png";
            fruitControl.imgBrush.ImageSource = new BitmapImage(new Uri(img, UriKind.Relative));

            Canvas.SetLeft(fruitControl, Canvas.GetLeft(fruitControl)+left);
            Canvas.SetTop(fruitControl, Canvas.GetTop(fruitControl)+top);

            elevenDays_GameServiceClient.Move(game, user.Login, new Position() { X = Canvas.GetLeft(fruitControl), Y = Canvas.GetTop(fruitControl) },state);
            //
        }

        bool isEnded = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            elevenDays_GameServiceClient.End(user.Login);

            MenuEDs menuEDs = new MenuEDs(user);
            menuEDs.Show();

            isEnded = true;
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (!isEnded)
            {
                elevenDays_GameServiceClient.End(user.Login);
            }
        }
    }
}
