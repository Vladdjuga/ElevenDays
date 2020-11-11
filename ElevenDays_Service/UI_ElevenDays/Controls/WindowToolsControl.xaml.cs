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

namespace UI_ElevenDays.Controls
{
    /// <summary>
    /// Логика взаимодействия для WindowToolsControl.xaml
    /// </summary>
    public partial class WindowToolsControl : UserControl
    {
        public WindowToolsControl()
        {
            InitializeComponent();

            dockPanel.DataContext = this;        
        }

        public string TextField
        {
            get { return (string)GetValue(TextFieldProperty); }
            set { SetValue(TextFieldProperty, value); }
        }

        public static readonly DependencyProperty TextFieldProperty =
            DependencyProperty.Register(nameof(TextField), typeof(string), typeof(WindowToolsControl), new PropertyMetadata(""));
    }
}
