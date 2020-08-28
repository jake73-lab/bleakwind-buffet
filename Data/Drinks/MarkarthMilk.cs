/*
 * Author: Jake Herman
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent a Markarth Milk and handle sizes
 */

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
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
                    return 1.05;
                }
                else if (size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
                }
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 56;
                }
                else if (size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
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

        private List<String> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public override string ToString()
        {
            return $"{size} Makarth Milk";
        }
    }
}
