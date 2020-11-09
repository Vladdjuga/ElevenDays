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
    /// Логика взаимодействия для MenuOptions.xaml
    /// </summary>
    public partial class MenuOptions : Window
    {
        public MenuOptions()
        {
            InitializeComponent();

            cb.Items.Add("800X600");
            cb.Items.Add("1280X720");
            cb.Items.Add("1440X900");
            cb.Items.Add("1920X1080");
            cb.Items.Add("2560X1440");
            cb.Items.Add("3840X2160");
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
