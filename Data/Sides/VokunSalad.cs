/*
 * Author: Jake Herman
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent a Vokun Salad and handle sizes
 */

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class describing a Vokun Salad
    /// </summary>
    public class VokunSalad : Side
    {
        private Size size = Size.Small;
        /// <summary>
        /// public getter/setter for the size of the salad
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
        /// public getter for the price of the salad, based on size
        /// </summary>
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

        /// <summary>
        /// public getter for the calories of the salad, based on size
        /// </summary>
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

        /// <summary>
        /// list of special instructions for preparing the salad
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// description of the salad
        /// </summary>
        /// <returns>string description of the salad</returns>
        public override string ToString()
        {
            return $"{size} Vokun Salad";
        }
    }
}
