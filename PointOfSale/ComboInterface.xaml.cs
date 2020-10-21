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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboInterface.xaml
    /// </summary>
    public partial class ComboInterface : UserControl
    {
        MainWindow window;
        Combo combo = new Combo(null, null, null);
        public ComboInterface(MainWindow _window)
        {
            InitializeComponent();
            window = _window;
            DataContext = combo;
            entreeChoices.ItemsSource = new List<IOrderItem>() { new ThalmorTriple(), new BriarheartBurger(), new DoubleDraugr(), new GardenOrcOmlette(), new SmokehouseSkeleton(), new ThugsTBone()};
            sideChoices.ItemsSource = new List<IOrderItem>() { new  DragonbornWaffleFries(), new MadOtarGrits(), new FriedMiraak(), new VokunSalad() };
            drinkChoices.ItemsSource = new List<IOrderItem>() { new SailorSoda(), new WarriorWater(), new CandlehearthCoffee(), new MarkarthMilk(), new AretinoAppleJuice() };
        }

        void Complete(object sender, RoutedEventArgs e)
        {
            window.menuContainer.Child = window.items;
        }

        private void entreeChoices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(entreeChoices.SelectedItem is BriarheartBurger)
            {
                entreeContainer.Child = new BriarheartBurgerCustomization(window);
            }
            else if(entreeChoices.SelectedItem is ThalmorTriple)
            {
                entreeContainer.Child = new ThalmorCustomization(window);
            }
            else if(entreeChoices.SelectedItem is DoubleDraugr)
            {
                entreeContainer.Child = new DoubleDraugrCustomization(window);
            }
            else if(entreeChoices.SelectedItem is GardenOrcOmlette)
            {
                entreeContainer.Child = new OmletteCustomization(window);
            }
            else if(entreeChoices.SelectedItem is SmokehouseSkeleton)
            {
                entreeContainer.Child = new SmokehouseCustomization(window);
            }
        }

        private void sideChoices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(sideChoices.SelectedItem is DragonbornWaffleFries)
            {
                sideContainer.Child = new FriesCustomization(window);
            }
            else if(sideChoices.SelectedItem is FriedMiraak)
            {
                sideContainer.Child = new MiraakCustomization(window);
            }
            else if(sideChoices.SelectedItem is MadOtarGrits)
            {
                sideContainer.Child = new GritsCustomization(window);
            }
            else if(sideChoices.SelectedItem is VokunSalad)
            {
                sideContainer.Child = new SaladCustomization(window);
            }
        }

        private void drinkChoices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(drinkChoices.SelectedItem is SailorSoda)
            {
                drinkContainer.Child = new SodaCustomization(window);
            }
            else if(drinkChoices.SelectedItem is WarriorWater)
            {
                drinkContainer.Child = new WaterCustomization(window);
            }
            else if(drinkChoices.SelectedItem is MarkarthMilk)
            {
                drinkContainer.Child = new MilkCustomization(window);
            }
            else if(drinkChoices.SelectedItem is CandlehearthCoffee)
            {
                drinkContainer.Child = new CoffeeCustomization(window);
            }
        }
    }
}
