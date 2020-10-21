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
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for RegisterComponent.xaml
    /// </summary>
    public partial class RegisterComponent : UserControl
    {
        CashHandler cashHandler = new CashHandler();
        public RegisterComponent()
        {
            InitializeComponent();
            DataContext = cashHandler;
        }

        private void finalizeSale_Click(object sender, RoutedEventArgs e)
        {

        }

        private void returnToOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addHundred_Click(object sender, RoutedEventArgs e)
        {
            cashHandler.hundredsCount++;
        }

        private void subHundred_Click(object sender, RoutedEventArgs e)
        {
            cashHandler.hundredsCount--;
        }
    }
}
