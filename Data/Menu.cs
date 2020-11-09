using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Xml;

namespace BleakwindBuffet.Data
{
    public class Menu
    {
        public Menu()
        {
        }

        public static IEnumerable<IOrderItem> Entrees()
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

        public static IEnumerable<IOrderItem> Sides()
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

        public static IEnumerable<IOrderItem> Drinks()
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

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.AddRange(Drinks());
            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Sides());
            return fullMenu;
        }

        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            foreach(IOrderItem item in items)
            {
                if(item.ToString().Contains(terms))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            foreach(string category in categories)
            {
                foreach(IOrderItem item in items)
                {
                    if (category.Equals("Entree"))
                    {
                        if (item is Entree)
                        {
                            results.Add(item);
                        }
                    }
                    else if(category.Equals("Drink"))
                    {
                        if(item is Drink)
                        {
                            results.Add(item);
                        }
                    }
                    else
                    {
                        if(item is Side)
                        {
                            results.Add(item);
                        }
                    }
                }
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null && max == null) return items;
            
            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Price < max) results.Add(item);
                }

                return results;
            }

            if(max == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Price > min) results.Add(item);
                }

                return results;
            }

            foreach(IOrderItem item in items)
            {
                if(item.Price > min && item.Price < max)
                {
                    results.Add(item);
                }
            }

            return results;
        }
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null && max == null) return items;
            
            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories < max) results.Add(item);
                }

                return results;
            }

            if(max == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories > min) results.Add(item);
                }

                return results;
            }

            foreach(IOrderItem item in items)
            {
                if(item.Calories > min && item.Price < max)
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }
}
