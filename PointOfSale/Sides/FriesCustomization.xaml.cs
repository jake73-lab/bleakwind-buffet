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
    /// Interaction logic for FriesCustomization.xaml
    /// </summary>
    public partial class FriesCustomization : UserControl
    {
        MainWindow window = new MainWindow();
        DragonbornWaffleFries fries = new DragonbornWaffleFries();
        public FriesCustomization(MainWindow _window)
        {
            InitializeComponent();
            window = _window;
            DataContext = fries;
        }

        void Complete(object sender, RoutedEventArgs e)
        {
            window.menuContainer.Child = window.items;
        }
    }
}
