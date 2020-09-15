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
    /// <summary>
    /// class describing Mad Otar Grits
    /// </summary>
    public class MadOtarGrits : Side
    {
        private Size size = Size.Small;
        /// <summary>
        /// public getter/setter for the size of the grits
        /// </summary>
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

        /// <summary>
        /// public getter for the price of the grits, based on size
        /// </summary>
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

        /// <summary>
        /// public getter for the calories of the grits, based on size
        /// </summary>
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

        /// <summary>
        /// list of special instructions for preparing the grits
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// describes the grits
        /// </summary>
        /// <returns>string description of the grits</returns>
        public override string ToString()
        {
            return $"{size} Mad Otar Grits";
        }
    }
}
