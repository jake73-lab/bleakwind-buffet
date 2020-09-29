using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    public class Menu
    {
        public Menu()
        {
        }

        public IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entree = new List<IOrderItem>();
            entree.Add(new BriarheartBurger());
            entree.Add(new DoubleDraugr());
            entree.Add(new GardenOrcOmlette());
            entree.Add(new PhillyPoacher());
            entree.Add(new SmokehouseSkeleton());
            entree.Add(new ThalmorTriple());
            entree.Add(new ThugsTBone());
            return entree;
        }

        public IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> side = new List<IOrderItem>();
            foreach(Size size in (Size[]) Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries fry = new DragonbornWaffleFries();
                fry.Size = size;
                side.Add(fry);
            }

            foreach (Size size in (Size[])Enum.GetValues(typeof(Size)))
            {
                FriedMiraak miraak = new FriedMiraak();
                miraak.Size = size;
                side.Add(miraak);
            }

            foreach (Size size in (Size[])Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits grits = new MadOtarGrits();
                grits.Size = size;
                side.Add(grits);
            }

            foreach (Size size in (Size[])Enum.GetValues(typeof(Size)))
            {
                VokunSalad salad = new VokunSalad();
                salad.Size = size;
                side.Add(salad);
            }

            return side;
        }

        public IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drink = new List<IOrderItem>();

            foreach (Size size in (Size[])Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice juice = new AretinoAppleJuice();
                juice.Size = size;
                drink.Add(juice);
            }

            foreach (Size size in (Size[])Enum.GetValues(typeof(Size)))
            {
                CandlehearthCoffee coffee = new CandlehearthCoffee();
                coffee.Size = size;
                drink.Add(coffee);
            }

            foreach (Size size in (Size[])Enum.GetValues(typeof(Size)))
            {
                MarkarthMilk milk = new MarkarthMilk();
                milk.Size = size;
                drink.Add(milk);
            }

            foreach (Size size in (Size[])Enum.GetValues(typeof(Size)))
            {
                WarriorWater water = new WarriorWater();
                water.Size = size;
                drink.Add(water);
            }

            foreach (Size size in (Size[])Enum.GetValues(typeof(Size)))
            {
                foreach(SodaFlavor flavor in (SodaFlavor[])Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda soda = new SailorSoda();
                    soda.Size = size;
                    soda.Flavor = flavor;
                    drink.Add(soda);
                }
            }

            return drink;
        }

        public IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.AddRange(Drinks());
            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Sides());
            return fullMenu;
        }
    }
}
