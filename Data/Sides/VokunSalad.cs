/*
 * Author: Jake Herman
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent a Vokun Salad and handle sizes
 */

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class VokunSalad
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
                    return .93;
                }
                else if (size == Size.Medium)
                {
                    return 1.28;
                }
                else
                {
                    return 1.82;
                }
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 41;
                }
                else if (size == Size.Medium)
                {
                    return 52;
                }
                else
                {
                    return 73;
                }
            }
        }

        private List<String> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public override string ToString()
        {
            return $"{size} Vokun Salad";
        }
    }
}
