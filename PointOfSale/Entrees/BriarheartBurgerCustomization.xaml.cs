﻿using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for BriarheartBurgerCustomization.xaml
    /// </summary>
    public partial class BriarheartBurgerCustomization : UserControl
    {
        MainWindow window = new MainWindow();
        private BriarheartBurger burger = new BriarheartBurger();
        public BriarheartBurgerCustomization(MainWindow _window)
        {
            InitializeComponent();
            window = _window;
            DataContext = burger;
        }

        void Complete(Object sender, RoutedEventArgs e)
        {
            window.menuContainer.Child = window.items;
            MainWindow.orderContext.Add(burger);
        }
    }
}
