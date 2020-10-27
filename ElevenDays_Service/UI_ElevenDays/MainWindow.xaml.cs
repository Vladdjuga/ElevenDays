﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using Microsoft.VisualBasic.Devices;

namespace UI_ElevenDays
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        Audio player = new Audio();
        public MenuWindow()
        {
            InitializeComponent();

            player.Play(@"..\..\Sound\export.wav");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
