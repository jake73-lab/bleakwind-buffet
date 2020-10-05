using BleakwindBuffet.Data.Sides;
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

namespace PointOfSale.Sides
{
    /// <summary>
    /// Interaction logic for SaladCustomization.xaml
    /// </summary>
    public partial class SaladCustomization : UserControl
    {
        MainWindow window = new MainWindow();
        VokunSalad salad = new VokunSalad();
        public SaladCustomization(MainWindow _window)
        {
            InitializeComponent();
            window = _window;
            DataContext = salad;
        }

        void Complete(object sender, RoutedEventArgs e)
        {
            window.menuContainer.Child = window.items;
        }
    }
}
