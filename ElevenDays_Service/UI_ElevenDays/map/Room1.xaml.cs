using PlayerCordons;
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

namespace UI_ElevenDays.map
{
    /// <summary>
    /// Логика взаимодействия для Room1.xaml
    /// </summary>
    public partial class Room1 : UserControl
    {
        public Room1()
        {
            InitializeComponent();

            foreach (var item in canvas.Children)
            {
                if(item is Button)
                {
                    if ((item as Button).Tag == "wall")
                        (item as Button).Content = new Hitbox() { StartPosition=new Position(Canvas.GetLeft((item as Button)), Canvas.GetTop((item as Button))), Height=(item as Button).Height, Width = (item as Button).Width };
                }
            }
        }
    }
}
