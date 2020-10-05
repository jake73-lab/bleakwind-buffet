using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for SodaCustomization.xaml
    /// </summary>
    public partial class SodaCustomization : UserControl
    {
        MainWindow window = new MainWindow();
        SailorSoda soda = new SailorSoda();
        public SodaCustomization(MainWindow _window)
        {
            InitializeComponent();
            window = _window;
            DataContext = soda;
        }

        void Complete(object sender, RoutedEventArgs e)
        {
            window.menuContainer.Child = window.items;
        }
    }
}
