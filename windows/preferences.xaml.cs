﻿using System;
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

namespace EV3_Control.windows
{
    /// <summary>
    /// Interaktionslogik für preferences.xaml
    /// </summary>
    public partial class preferences : Window
    {

        MainWindow window = new MainWindow();
        public preferences()
        {
            InitializeComponent();
            
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            
         
            window.WindowState = WindowState.Normal;
            window.Show();
            window.Top = this.Top;
            window.Left = this.Left;


            this.Close();

        }
    }
}