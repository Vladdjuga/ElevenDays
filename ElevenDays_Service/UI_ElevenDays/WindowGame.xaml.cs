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

namespace UI_ElevenDays
{
    /// <summary>
    /// Логика взаимодействия для WindowGame.xaml
    /// </summary>
    public partial class WindowGame : Window
    {
        public WindowGame()
        {
            InitializeComponent();
            for (int i = 0; i < 50; i++)
            {
                Canvas.SetTop(Ch, Canvas.GetTop(Ch) + 10);
            }
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Azazaza2");
            if(e.Key == Key.Up)
            {
                MessageBox.Show(e.Key.ToString());
                Canvas.SetTop(Ch, Canvas.GetTop(Ch) + 10);
            }
            if (e.Key == Key.Down)
            {
                MessageBox.Show(e.Key.ToString());
                Canvas.SetBottom(Ch, Canvas.GetBottom(Ch) + 10);
            }
            if (e.Key == Key.Left)
            {
                MessageBox.Show(e.Key.ToString());
                Canvas.SetLeft(Ch, Canvas.GetLeft(Ch) + 10);
            }
            if (e.Key == Key.Right)
            {
                MessageBox.Show(e.Key.ToString());
                Canvas.SetRight(Ch, Canvas.GetRight(Ch) + 10);
            }
        }
    }
}
