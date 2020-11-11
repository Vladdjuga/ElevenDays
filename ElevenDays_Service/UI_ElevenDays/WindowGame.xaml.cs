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
using UI_ElevenDays.Controls.Rooms;
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
        string character;

        object currRoom;

        public WindowGame(UserDTO user, string game, string character)
        {
            InitializeComponent();

            tbCode.Text = game;

            callback.Count=100;

            callback.PlayerChangedEvent += Callback_PlayerChangedEvent;
            callback.DisconnectedEvent += Callback_DisconnectedEvent;
            callback.StateEvent += Callback_StateEvent;
            callback.MoveEvent += Callback_MoveEvent;
            callback.NewPlayerArrivedEvent += Callback_NewPlayerArrivedEvent;

            elevenDays_GameServiceClient = new ElevenDays_GameServiceClient(new System.ServiceModel.InstanceContext(callback));

            elevenDays_GameServiceClient.StartByGameID(game, user,character);

            this.user = user;
            this.game = game;
            this.character = character;

            for (int i = 0; i < elevenDays_GameServiceClient.GetPlayersCount(game); i++)
            {
                string str = elevenDays_GameServiceClient.GetPlayerString(game, i);
                string charact = elevenDays_GameServiceClient.GetPlayerFruit(game, i);
                Position position = elevenDays_GameServiceClient.GetPlayerPosition(game, i);
                if (str!=user.Login)
                Callback_NewPlayerArrivedEvent(position, str, charact);
            }

            fruitControl = new FruitControl($"Images/{character}Ch2.png", new Position() { X=0, Y=0 },user.Login);
            fruitControl.Tag = user.Login;

            currRoom = new StartRoom(fruitControl,fruitControls);
            fruitControl.Room = "bath";
            dockpanel.Children.Add((currRoom as StartRoom));
        }

        private void Callback_PlayerChangedEvent(string login, string roomOld, string roomNew)
        {
            FruitControl fruitControl = fruitControls.First(el => el.Tag.ToString() == login);

            if (roomOld != roomNew)
            {
                if (currRoom is StartRoom && roomOld == "bath")
                    (currRoom as StartRoom).canvas.Children.Remove(fruitControl);
                if (currRoom is KitchenRoon && roomOld == "kitchen")
                    (currRoom as KitchenRoon).canvas.Children.Remove(fruitControl);

                if (currRoom is StartRoom && roomNew == "bath")
                    (currRoom as StartRoom).canvas.Children.Add(fruitControl);
                if (currRoom is KitchenRoon && roomNew == "kitchen")
                    (currRoom as KitchenRoon).canvas.Children.Add(fruitControl);
            }
        }

        private void Callback_DisconnectedEvent(string login)
        {
            FruitControl fruitControl = fruitControls.First(el => el.Tag.ToString() == login);

            if (currRoom is StartRoom)
                (currRoom as StartRoom).canvas.Children.Remove(fruitControl);
            if (currRoom is KitchenRoon)
                (currRoom as KitchenRoon).canvas.Children.Remove(fruitControl);
            fruitControls.Remove(fruitControl);
        }

        private void Callback_StateEvent(string state, string login, string charact)
        {
            FruitControl fruitControl = fruitControls.First(el => el.Tag.ToString() == login);

            string img="";
            if (state == "StayRight")
                img = $"Images/{charact}Ch2.png";
            if(state=="StayLeft")
                img = $"Images/{charact}Ch1.png";

            fruitControl.imgBrush.ImageSource = new BitmapImage(new Uri(img, UriKind.Relative));
        }

        private void Callback_NewPlayerArrivedEvent(Position position, string login, string character)
        {
            FruitControl fruitControl = new FruitControl($"Images/{character}Ch2.png", position,login);
            fruitControl.Tag = login;

            string room = elevenDays_GameServiceClient.PlayerCurrentRoomByLogin(game, login);

            fruitControl.Room = room;

            if (room=="bath")
            if (currRoom is StartRoom)
                (currRoom as StartRoom).canvas.Children.Add(fruitControl);
            if(room=="kitchen")
            if (currRoom is KitchenRoon)
                (currRoom as KitchenRoon).canvas.Children.Add(fruitControl);

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

            bool isE = false;

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
                if (e.Key == Key.E)
                {
                    isE = true;
                }
            }).Wait();

            //elevenDays_GameServiceClient.ChangePlayerState(game, user.Login, state);

            string img = "";
            if (state == "StayRight")
                img = $"Images/{character}Ch2.png";
            if (state == "StayLeft")
                img = $"Images/{character}Ch1.png";
            else
                img = $"Images/{character}Ch2.png";

            fruitControl.imgBrush.ImageSource = new BitmapImage(new Uri(img, UriKind.Relative));

            Canvas.SetLeft(fruitControl, Canvas.GetLeft(fruitControl)+left);
            Canvas.SetTop(fruitControl, Canvas.GetTop(fruitControl)+top);

            string res="";
            if (currRoom is StartRoom)
            {
                res = (currRoom as StartRoom).CheckOnCloseContact(fruitControl);
                if (isE && res != "")
                    (currRoom as StartRoom).canvas.Children.Remove(fruitControl);
            }
            if (currRoom is KitchenRoon)
            {
                res = (currRoom as KitchenRoon).CheckOnCloseContact(fruitControl);
                if (isE && res != "")
                    (currRoom as KitchenRoon).canvas.Children.Remove(fruitControl);
            }

            if (isE&&res!="")
            {
                if (res == "kitchen")
                {
                    currRoom = new KitchenRoon(fruitControl, fruitControls.Where(el=>el.Room==res).ToList());
                }
                if (res == "bath")
                {
                    currRoom = new StartRoom(fruitControl, fruitControls.Where(el => el.Room == res).ToList());
                }
                fruitControl.Room = res;
            }

            dockpanel.Children.Clear();
            dockpanel.Children.Add((currRoom as UIElement));

            elevenDays_GameServiceClient.Move(game, user.Login, new Position() { X = Canvas.GetLeft(fruitControl), Y = Canvas.GetTop(fruitControl) },state);

            //
        }

        private void ChangeCurrRoom()
        {
            dockpanel.Children.Clear();
            dockpanel.Children.Add((currRoom as UIElement));
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
