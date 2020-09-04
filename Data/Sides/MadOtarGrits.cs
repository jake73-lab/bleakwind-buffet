/*
 * Author: Jake Herman
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent a MadOtarGrits and handle sizes
 */

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
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
                    return 1.22;
                }
                else if (size == Size.Medium)
                {
                    return 1.58;
                }
                else
                {
                    return 1.93;
                }
            }
        }

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 105;
                }
                else if (size == Size.Medium)
                {
                    return 142;
                }
                else
                {
                    return 179;
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
            return $"{size} Mad Otar Grits";
        }
    }
}
