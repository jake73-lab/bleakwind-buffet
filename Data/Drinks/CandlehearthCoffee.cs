/*
 * Author: Jake Herman
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth Coffee and handle sizes
 */

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
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

        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return .75;
                }
                else if (size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 7;
                }
                else if (size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }

        private bool ice = false;
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
                    specialInstructions.Add("Add ice");
                }
                else
                {
                    specialInstructions.Remove("Add ice");
                }
                ice = value;
            }
        }

        private bool roomForCream = false;
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Add cream");
                }
                else
                {
                    specialInstructions.Remove("Add cream");
                }
                roomForCream = value;
            }
        }

        private bool decaf = false;
        public bool Decaf
        {
            get
            {
                return decaf;
            }

            set
            {
                decaf = value;
            }
        }

        private List<String> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public override string ToString()
        {
            if(decaf)
            {
                return $"{size} Decaf Candlehearth Coffee";
            }
            else
            {
                return $"{size} Candlehearth Coffee";
            }
        }
    }
}
