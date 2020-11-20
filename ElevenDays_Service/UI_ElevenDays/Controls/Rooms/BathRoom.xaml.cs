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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI_ElevenDays.Controls.Rooms
{
    /// <summary>
    /// Логика взаимодействия для BathRoom.xaml
    /// </summary>
    public partial class BathRoom : UserControl
    {
        FruitControl fruitControl;
        public List<FruitControl> fruitControls = new List<FruitControl>();
        public BathRoom(FruitControl fruitControl, List<FruitControl> fruitControls)
        {
            InitializeComponent();

            this.fruitControl = fruitControl;
            this.fruitControls = fruitControls;

            canvas.Children.Add(fruitControl);
            foreach (var item in fruitControls)
            {
                canvas.Children.Add(item);
            }
        }
        public string CheckOnCloseContact(FruitControl fruitControl)
        {
            door1.BorderThickness = new Thickness(0);
            door2.BorderThickness = new Thickness(0);
            door3.BorderThickness = new Thickness(0);
            //door4.BorderThickness = new Thickness(0);

            double xD1 = Canvas.GetLeft(door1), yD1 = Canvas.GetTop(door1);
            double xD2 = Canvas.GetLeft(door2), yD2 = Canvas.GetTop(door2);
            double xD3 = Canvas.GetLeft(door3), yD3 = Canvas.GetTop(door3);
            //double xD4 = Canvas.GetLeft(door4), yD4 = Canvas.GetTop(door4);

            double xF = Canvas.GetLeft(fruitControl), yF = Canvas.GetTop(fruitControl);

            if (xF <= xD1 + 200 && yF <= yD1 + 200 && yF >= yD1 - 300)
            {
                door1.BorderThickness = new Thickness(5);
                return door1.Tag.ToString();
            }
            else if (xF >= xD3 - 200 && xF <= xD3 + 300 && yF <= yD3 + 200)
            {
                door3.BorderThickness = new Thickness(5);
                return door3.Tag.ToString();
            }
            else if (xF >= xD2 - 300 && yF <= yD2 + 300 && yF >= yD2 - 300)
            {
                door2.BorderThickness = new Thickness(5);
                return door2.Tag.ToString();
            }
            //else if (xF >= xD4 - 300 && xF <= xD4 + 300 && yF >= yD4 - 400)
            //{
            //    door4.BorderThickness = new Thickness(5);
            //    return door4.Tag.ToString();
            //}
            return "";
        }
        public string CheckOnWhatOrientation(string tag)
        {
            if (door1.Tag == tag || door2.Tag == tag)
                return "horizontal";
            if (door3.Tag == tag /*|| door4.Tag == tag*/)
                return "vertical";
            return "";
        }
        public bool IsContactWithPhysElements(FruitControl fruitControl, int top, int left)
        {
            foreach (var item in canvas.Children)
            {
                if (item is Border)
                {
                    if ((item as Border).Tag.ToString() == "phys")
                    {
                        //MessageBox.Show($"{Canvas.GetLeft(fruitControl)}/{fruitControl.Width}/{Canvas.GetLeft((item as Border))}/{(item as Border).Width}||{Canvas.GetTop(fruitControl)}/{Canvas.GetTop((item as Border))}/{(item as Border).Height}/{fruitControl.Height}");
                        if ((Canvas.GetLeft(fruitControl) + fruitControl.Width + left > Canvas.GetLeft((item as Border)) &&
                            Canvas.GetLeft(fruitControl) + left < Canvas.GetLeft((item as Border)) + (item as Border).Width) &&
                            (Canvas.GetTop(fruitControl) + top < Canvas.GetTop((item as Border)) + (item as Border).Height &&
                            Canvas.GetTop(fruitControl) + fruitControl.Height + top >= Canvas.GetTop((item as Border))))
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
