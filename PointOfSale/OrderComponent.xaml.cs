using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
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
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        List<object> selected;

        public OrderComponent()
        {
            InitializeComponent();
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            IOrderItem item = (IOrderItem)itemsListView.SelectedItem;
            MainWindow.orderContext.Remove((IOrderItem) item);
        }

        private void itemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
