﻿using DLL_User;
using Microsoft.Win32;
using System;
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
using UI_ElevenDays.ServiceReference2;

namespace UI_ElevenDays
{
    /// <summary>
    /// Логика взаимодействия для MenuEDs.xaml
    /// </summary>
    public partial class MenuEDs : Window
    {
        public MediaPlayer soundPlay = new MediaPlayer();
        UserDTO user = new UserDTO();
        //public MenuEDs(UserDTO user)
        //{
        //    InitializeComponent();
        //    soundPlay.Open(new Uri(@"Sound/Happy Three Friends.mp3", UriKind.Relative));
        //    soundPlay.Play();
        //    this.user = user;
        //}

        public MenuEDs(UserDTO user)
        {
            InitializeComponent();
            soundPlay.Open(new Uri(@"Sound/Happy Three Friends.mp3", UriKind.Relative));
            soundPlay.Volume = 0.05;
            soundPlay.Play();
            this.user = user;

            elevenDays_GameServiceClient = new ElevenDays_GameServiceClient(new System.ServiceModel.InstanceContext(callbackHandler));
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


        private void btnStart_MouseMove(object sender, MouseEventArgs e)
        {
            ImageBrush imB = new ImageBrush();
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri("Images/StartImEDs.png", UriKind.Relative);
            bit.EndInit();
            imB.Stretch = Stretch.Fill;
            imB.ImageSource = bit;
            gridВ.Background = imB;

            soundPlay.Open(new Uri(@"Sound/Scarry Voise to Start btn.mp3", UriKind.Relative));
            soundPlay.Volume = 0.05;
            soundPlay.Play();
        }

        private void btnOpt_MouseMove(object sender, MouseEventArgs e)
        {
            ImageBrush imB = new ImageBrush();
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri("Images/MenuOptions.png", UriKind.Relative);
            bit.EndInit();
            imB.Stretch = Stretch.Fill;
            imB.ImageSource = bit;
            gridВ.Background = imB;

            soundPlay.Open(new Uri(@"Sound/Voise to Option btn.mp3", UriKind.Relative));
            soundPlay.Volume = 0.5;
            soundPlay.Play();
        }
        private void btnEx_MouseMove(object sender, MouseEventArgs e)
        {
            ImageBrush imB = new ImageBrush();
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri("Images/ExitBackground.png", UriKind.Relative);
            bit.EndInit();
            imB.Stretch = Stretch.Fill;
            imB.ImageSource = bit;
            gridВ.Background = imB;

            soundPlay.Open(new Uri(@"Sound/Scary Voise to Exit btn.mp3", UriKind.Relative));
            soundPlay.Volume = 1;
            soundPlay.Play();
        }

        private void btnOpt_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuOptions menuOptions = new MenuOptions();
            if (menuOptions.ShowDialog() == true)
                this.Show();
        }

        ElevenDays_GameServiceClient elevenDays_GameServiceClient;
        CallbackHandler callbackHandler = new CallbackHandler();
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            SelectGameWindow selectGameWindow = new SelectGameWindow(user);
            selectGameWindow.Show();
            this.Close();
        }

        private void MouseLeave(object sender, MouseEventArgs e)
        {
            ImageBrush imB = new ImageBrush();
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri("Images/HappyImEDs.png", UriKind.Relative);
            bit.EndInit();
            imB.Stretch = Stretch.Fill;
            imB.ImageSource = bit;
            gridВ.Background = imB;
            soundPlay.Volume = 0.05;
            soundPlay.Open(new Uri(@"Sound/Happy Three Friends.mp3", UriKind.Relative));
            soundPlay.Play();
        }

        private void btnEx_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
