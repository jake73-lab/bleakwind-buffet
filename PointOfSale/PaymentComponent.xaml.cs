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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentComponent.xaml
    /// </summary>
    public partial class PaymentComponent : UserControl
    {
        public PaymentComponent()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cashPayment_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.menuComponent.Child = new RegisterComponent();
        }

        private void cardPayment_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
