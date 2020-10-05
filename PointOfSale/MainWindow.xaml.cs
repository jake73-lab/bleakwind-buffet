using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PointOfSale.Entrees;
using PointOfSale.Drinks;
using PointOfSale.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<IOrderItem> order = new List<IOrderItem>();
        public ItemComponent items = new ItemComponent();

        public MainWindow() 
        {
            InitializeComponent();
            items.Selection += HandleItem;
            menuContainer.Child = items;
        }

        void HandleItem(object sender, SelectionHandler e)
        {
            if (e.item.GetType().IsSubclassOf(typeof(Entree)))
            {
                if (e.item is BriarheartBurger) menuContainer.Child = new BriarheartBurgerCustomization(this);
                if (e.item is DoubleDraugr) menuContainer.Child = new DoubleDraugrCustomization(this);
                if (e.item is GardenOrcOmlette) menuContainer.Child = new OmletteCustomization(this);
                if (e.item is PhillyPoacher) menuContainer.Child = new PhillyCustomization(this);
                if (e.item is SmokehouseSkeleton) menuContainer.Child = new SmokehouseCustomization(this);
                if (e.item is ThalmorTriple) menuContainer.Child = new ThalmorCustomization(this);
            }
            else if (e.item.GetType().IsSubclassOf(typeof(Drink)))
            {
                if (e.item is AretinoAppleJuice) menuContainer.Child = new AretinoCustomization(this);
                if (e.item is CandlehearthCoffee) menuContainer.Child = new CoffeeCustomization(this);
                if (e.item is MarkarthMilk) menuContainer.Child = new MilkCustomization(this);
                if (e.item is SailorSoda) menuContainer.Child = new SodaCustomization(this);
                if (e.item is WarriorWater) menuContainer.Child = new WaterCustomization(this);
            }
            else if (e.item.GetType().IsSubclassOf(typeof(Side)))
            {
                if (e.item is VokunSalad) menuContainer.Child = new SaladCustomization(this);
                if (e.item is MadOtarGrits) menuContainer.Child = new GritsCustomization(this);
                if (e.item is DragonbornWaffleFries) menuContainer.Child = new FriesCustomization(this);
                if (e.item is FriedMiraak) menuContainer.Child = new MiraakCustomization(this);
            }
        }
    }
}
