﻿using mvvmDataBase.VewModel;
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

namespace mvvmDataBase.View
{
    /// <summary>
    /// Логика взаимодействия для settungWindow.xaml
    /// </summary>
    public partial class settungWindow : Window
    {
        public settungWindow()
        {
            InitializeComponent();
            DataContext = new SettingViewModel();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
