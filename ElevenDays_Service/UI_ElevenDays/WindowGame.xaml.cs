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
        CallbackHandler callbackHandler = new CallbackHandler();
        FruitControl fruitControl;

        UserDTO userDTO;
        string game;

        List<FruitControl> fruitControls = new List<FruitControl>();
        public WindowGame(UserDTO user, string game)
        {
            InitializeComponent();

            this.userDTO = user;
            this.game = game;

            elevenDays_GameServiceClient = new ElevenDays_GameServiceClient(new System.ServiceModel.InstanceContext(callbackHandler));

            fruitControl = new FruitControl(@"../../Images/BananaCh2.png", new Position() { X = 0, Y = 500 });

            callbackHandler.MoveEvent += CallbackHandler_MoveEvent;

            canvas.Children.Add(fruitControl);
        }

        private void CallbackHandler_MoveEvent(Position position, string login)
        {

            FruitControl fruitControl = fruitControls.First(el => el.Tag.ToString() == login);
            if (fruitControl != null)
            {
                Canvas.SetTop(fruitControl, position.Y);
                Canvas.SetLeft(fruitControl, position.X);
            }
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
                else if (e.Key == Key.Down)
                {
                    top += 10;
                }
                else if (e.Key == Key.Left)
                {
                    left -= 10;
                }
                else if (e.Key == Key.Right)
                {
                    left += 10;
                }
            }).Wait();

            Canvas.SetTop(fruitControl, Canvas.GetTop(fruitControl) + top);
            Canvas.SetLeft(fruitControl, Canvas.GetLeft(fruitControl) + left);

            elevenDays_GameServiceClient.Move(game, userDTO.Login, new Position() { X = Canvas.GetLeft(fruitControl), Y = Canvas.GetTop(fruitControl) });
        }
    }
}
