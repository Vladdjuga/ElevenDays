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
using UI_ElevenDays.ServiceReference2;

namespace UI_ElevenDays.Controls
{
    /// <summary>
    /// Логика взаимодействия для FruitControl.xaml
    /// </summary>
    public partial class FruitControl : UserControl
    {
        public FruitControl(string imageSrc,Position position,string login)
        {
            InitializeComponent();

            lblName.Content = login;

            imgBrush.ImageSource = new BitmapImage(new Uri(imageSrc,UriKind.Relative));
            Canvas.SetLeft(this, position.X);
            Canvas.SetTop(this, position.Y);
        }
        public string Room { get; set; }
    }
}
