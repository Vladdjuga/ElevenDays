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
                Callback_NewPlayerArrivedEvent(position, str, charact, "chill");
            }

            fruitControl = new FruitControl($"Images/{character}Ch2.png", new Position() { X=0, Y=0 },user.Login);
            fruitControl.Tag = user.Login;

            currRoom = new StartRoom(fruitControl,fruitControls);
            fruitControl.Room = "chill";
            dockpanel.Children.Add((currRoom as StartRoom));
        }

        private void Callback_PlayerChangedEvent(string login, string room)
        {
            FruitControl fruitControl = fruitControls.First(el => el.Tag.ToString() == login);

            fruitControl.Room = room;

            if (currRoom is StartRoom && room != "chill")
            {
                if ((currRoom as StartRoom).canvas.Children.Contains(fruitControl))
                    (currRoom as StartRoom).canvas.Children.Remove(fruitControl);
            }
            if (currRoom is KitchenRoon && room != "kitchen")
            {
                if ((currRoom as KitchenRoon).canvas.Children.Contains(fruitControl))
                    (currRoom as KitchenRoon).canvas.Children.Remove(fruitControl);
            }
            if (currRoom is BathRoom && room != "bath")
            {
                if ((currRoom as BathRoom).canvas.Children.Contains(fruitControl))
                    (currRoom as BathRoom).canvas.Children.Remove(fruitControl);
            }
            if (currRoom is MasterRoom && room != "maist")
            {
                if ((currRoom as MasterRoom).canvas.Children.Contains(fruitControl))
                    (currRoom as MasterRoom).canvas.Children.Remove(fruitControl);
            }
            if (currRoom is MedBayRoom && room != "medbay")
            {
                if ((currRoom as MedBayRoom).canvas.Children.Contains(fruitControl))
                    (currRoom as MedBayRoom).canvas.Children.Remove(fruitControl);
            }

            if (currRoom is StartRoom && room == "chill")
                if (!(currRoom as StartRoom).canvas.Children.Contains(fruitControl))
                    (currRoom as StartRoom).canvas.Children.Add(fruitControl);

            if (currRoom is KitchenRoon && room == "kitchen")
                if ((currRoom as KitchenRoon).canvas.Children.Contains(fruitControl))
                    (currRoom as KitchenRoon).canvas.Children.Add(fruitControl);

            if (currRoom is BathRoom && room == "bath")
                if (!(currRoom as BathRoom).canvas.Children.Contains(fruitControl))
                    (currRoom as BathRoom).canvas.Children.Add(fruitControl);

            if (currRoom is MasterRoom && room == "maist")
                if ((currRoom as MasterRoom).canvas.Children.Contains(fruitControl))
                    (currRoom as MasterRoom).canvas.Children.Add(fruitControl);

            if (currRoom is MedBayRoom && room == "medbay")
                if (!(currRoom as MedBayRoom).canvas.Children.Contains(fruitControl))
                    (currRoom as MedBayRoom).canvas.Children.Add(fruitControl);
        }

        private void Callback_DisconnectedEvent(string login)
        {
            FruitControl fruitControl = fruitControls.First(el => el.Tag.ToString() == login);

            if (currRoom is StartRoom)
                (currRoom as StartRoom).canvas.Children.Remove(fruitControl);
            if (currRoom is KitchenRoon)
                (currRoom as KitchenRoon).canvas.Children.Remove(fruitControl);
            if (currRoom is BathRoom)
                (currRoom as BathRoom).canvas.Children.Remove(fruitControl);
            if (currRoom is MasterRoom)
                (currRoom as MasterRoom).canvas.Children.Remove(fruitControl);
            if (currRoom is MedBayRoom)
                (currRoom as MedBayRoom).canvas.Children.Remove(fruitControl);

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
            else
                img = $"Images/{charact}Ch2.png";

            fruitControl.imgBrush.ImageSource = new BitmapImage(new Uri(img, UriKind.Relative));
        }

        private void Callback_NewPlayerArrivedEvent(Position position, string login, string character,string room)
        {
            FruitControl fruitControl = new FruitControl($"Images/{character}Ch2.png", position,login);
            fruitControl.Tag = login;

            fruitControl.Room = room;

            if (room=="chill")
            if (currRoom is StartRoom)
                (currRoom as StartRoom).canvas.Children.Add(fruitControl);
            if(room=="kitchen")
            if (currRoom is KitchenRoon)
                (currRoom as KitchenRoon).canvas.Children.Add(fruitControl);
            if (room == "bath")
                if (currRoom is BathRoom)
                    (currRoom as BathRoom).canvas.Children.Add(fruitControl);
            if (room == "maist")
                if (currRoom is MasterRoom)
                    (currRoom as MasterRoom).canvas.Children.Add(fruitControl);
            if (room == "medbay")
                if (currRoom is MedBayRoom)
                    (currRoom as MedBayRoom).canvas.Children.Add(fruitControl);

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

            if (Canvas.GetLeft(fruitControl) + left >= 0 && Canvas.GetLeft(fruitControl) + left + fruitControl.Width <= 1920 && Canvas.GetTop(fruitControl) + top >= 0 && Canvas.GetTop(fruitControl) + top + fruitControl.Height <= 1080)
            {
                Canvas.SetLeft(fruitControl, Canvas.GetLeft(fruitControl) + left);
                Canvas.SetTop(fruitControl, Canvas.GetTop(fruitControl) + top);

                string res = "";
                string orient = "";

                ClearCurrentRoom(out res, isE,out orient);
                
                if (isE && res != "")
                {
                    double w=0, h=0;
                    if (res == "kitchen")
                    {
                        currRoom = new KitchenRoon(fruitControl, fruitControls.Where(el => el.Room == res).ToList());
                    }
                    if (res == "bath")
                    {
                        currRoom = new BathRoom(fruitControl, fruitControls.Where(el => el.Room == res).ToList());
                    }
                    if (res == "chill")
                    {
                        currRoom = new StartRoom(fruitControl, fruitControls.Where(el => el.Room == res).ToList());
                    }
                    if (res == "maist")
                    {
                        currRoom = new MasterRoom(fruitControl, fruitControls.Where(el => el.Room == res).ToList());
                    }
                    if (res == "medbay")
                    {
                        currRoom = new MedBayRoom(fruitControl, fruitControls.Where(el => el.Room == res).ToList());
                    }

                    if (orient == "horizontal")
                        Canvas.SetLeft(fruitControl, 1920 - Canvas.GetLeft(fruitControl) - fruitControl.Width);
                    if(orient=="vertical")
                        Canvas.SetTop(fruitControl, 1080 - Canvas.GetTop(fruitControl)-fruitControl.Height);

                    fruitControl.Room = res;
                }

                dockpanel.Children.Clear();
                dockpanel.Children.Add((currRoom as UIElement));

                elevenDays_GameServiceClient.Move(game, user.Login, new Position() { X = Canvas.GetLeft(fruitControl), Y = Canvas.GetTop(fruitControl) }, state, fruitControl.Room);

                //
            }
        }

        private void ClearCurrentRoom(out string res, bool isE,out string orient)
        {
            res = "";
            orient = "";
            if (currRoom is StartRoom)
            {
                res = (currRoom as StartRoom).CheckOnCloseContact(fruitControl);
                orient = (currRoom as StartRoom).CheckOnWhatOrientation(res);
                if (isE && res != "")
                {
                    (currRoom as StartRoom).canvas.Children.Remove(fruitControl);
                    foreach (var item in fruitControls.Where(el => el.Room == "chill").ToList())
                    {
                        (currRoom as StartRoom).canvas.Children.Remove(item);
                    }
                }
            }
            if (currRoom is KitchenRoon)
            {
                res = (currRoom as KitchenRoon).CheckOnCloseContact(fruitControl);
                orient = (currRoom as KitchenRoon).CheckOnWhatOrientation(res);
                if (isE && res != "")
                {
                    (currRoom as KitchenRoon).canvas.Children.Remove(fruitControl);
                    foreach (var item in fruitControls.Where(el => el.Room == "kitchen").ToList())
                    {
                        (currRoom as KitchenRoon).canvas.Children.Remove(item);
                    }
                }
            }
            if (currRoom is BathRoom)
            {
                res = (currRoom as BathRoom).CheckOnCloseContact(fruitControl);
                orient = (currRoom as BathRoom).CheckOnWhatOrientation(res);
                if (isE && res != "")
                {
                    (currRoom as BathRoom).canvas.Children.Remove(fruitControl);
                    foreach (var item in fruitControls.Where(el => el.Room == "bath").ToList())
                    {
                        (currRoom as BathRoom).canvas.Children.Remove(item);
                    }
                }
            }
            if (currRoom is MedBayRoom)
            {
                res = (currRoom as MedBayRoom).CheckOnCloseContact(fruitControl);
                orient = (currRoom as MedBayRoom).CheckOnWhatOrientation(res);
                if (isE && res != "")
                {
                    (currRoom as MedBayRoom).canvas.Children.Remove(fruitControl);
                    foreach (var item in fruitControls.Where(el => el.Room == "medbay").ToList())
                    {
                        (currRoom as MedBayRoom).canvas.Children.Remove(item);
                    }
                }
            }
            if (currRoom is MasterRoom)
            {
                res = (currRoom as MasterRoom).CheckOnCloseContact(fruitControl);
                orient = (currRoom as MasterRoom).CheckOnWhatOrientation(res);
                if (isE && res != "")
                {
                    (currRoom as MasterRoom).canvas.Children.Remove(fruitControl);
                    foreach (var item in fruitControls.Where(el => el.Room == "maist").ToList())
                    {
                        (currRoom as MasterRoom).canvas.Children.Remove(item);
                    }
                }
            }
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
