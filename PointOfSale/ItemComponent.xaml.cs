using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ItemComponent.xaml
    /// </summary>
    public partial class ItemComponent : UserControl
    {
        public event EventHandler<SelectionHandler> Selection;
        public ItemComponent()
        {
            InitializeComponent();
        }

        void AddBBurger(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new BriarheartBurger() });
        }

        void AddSSoda(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new SailorSoda() });
        }     

        void AddSalad(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new VokunSalad() });
        }
        void AddDraugr(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new DoubleDraugr() });
        }

        void AddMilk(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new MarkarthMilk() });
        }

        void AddMiraak(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new FriedMiraak() });
        }

        void AddThalmor(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new ThalmorTriple() });
        }

        void AddAretino(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new AretinoAppleJuice() });
        }

        void AddGrits(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new MadOtarGrits() });
        }

        void AddSmokehouse(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new SmokehouseSkeleton() });
        }

        void AddCoffee(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new CandlehearthCoffee() });
        }

        void AddFries(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new DragonbornWaffleFries() });
        }

        void AddOmlette(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new GardenOrcOmlette() });
        }

        void AddWater(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new WarriorWater() });
        }
        void AddTBone(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new ThugsTBone() });
        }

        void AddCombo(object sender, RoutedEventArgs e)
        {
            Selection?.Invoke(this, new SelectionHandler() { item = new Combo(null, null, null) });
        }

    }
}
