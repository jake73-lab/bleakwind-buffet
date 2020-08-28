/*
 * Author: Jake Herman
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent a Sailor Soda and handle sizes
 */

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }

            set
            {
                flavor = value;
            }
        }

        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.42;
                }
                else if (size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }
            }
        }

        public uint Calories
        {
            get
            {
                if(size == Size.Small)
                {
                    return 117;
                }
                else if(size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }

        private bool ice = true;
        public bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                if (!value)
                {

                    specialInstructions.Add("Hold ice");
                }
                else
                {
                    specialInstructions.Remove("Hold ice");
                }
                ice = value;
            }
        }

        private List<String> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public override string ToString()
        {
            return $"{size} {flavor} Sailor Soda";
        }
    }
}
