using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for ThalmorCustomization.xaml
    /// </summary>
    public partial class ThalmorCustomization : UserControl
    {
        MainWindow window = new MainWindow();
        ThalmorTriple triple = new ThalmorTriple();
        public ThalmorCustomization(MainWindow _window)
        {
            InitializeComponent();
            window = _window;
            DataContext = triple;
        }

        void Complete(object sender, RoutedEventArgs e)
        {
            window.menuContainer.Child = window.items;
        }
    }
}
