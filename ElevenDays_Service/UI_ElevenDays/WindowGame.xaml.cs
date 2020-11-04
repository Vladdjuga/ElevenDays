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

            elevenDays_GameServiceClient = new ElevenDays_GameServiceClient(new System.ServiceModel.InstanceContext(callback));

            this.user = user;
            this.game = game;

            fruitControl = new FruitControl("Images/BananaCh2.png",new Position() { X=0, Y=500 });
            fruitControl.Tag = game;

            callback.MoveEvent += Callback_MoveEvent;
            canvas.Children.Add(fruitControl);
        }

        private void Callback_MoveEvent(Position position, string login)
        {
            FruitControl fruitControl = fruitControls.First(el => el.Tag.ToString() == login);

            Canvas.SetLeft(fruitControl, position.X);
            Canvas.SetLeft(fruitControl, position.Y);
        }

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
                }
                if (e.Key == Key.Right)
                {
                    left += 10;
                }
            }).Wait();

            Canvas.SetLeft(fruitControl, Canvas.GetLeft(fruitControl)+left);
            Canvas.SetTop(fruitControl, Canvas.GetTop(fruitControl)+top);

            elevenDays_GameServiceClient.Move(game, user.Login, new Position() { X = Canvas.GetLeft(fruitControl), Y = Canvas.GetTop(fruitControl) });
        }
    }
}
