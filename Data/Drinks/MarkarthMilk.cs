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
    /// <summary>
    /// Represents a MakarthMilk
    /// </summary>
    public class MarkarthMilk : Drink
    {
        private Size size = Size.Small;
        /// <summary>
        /// public getter/setter for the size of the makarth milk
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
        /// public getter for the price of the makarth milk, dependent on size
        /// </summary>
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

        /// <summary>
        /// public getter for the calories of the makarth milk, dependent on size
        /// </summary>
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
        /// <summary>
        /// public getter/setter flagging whether or not the milk has ice, false by default
        /// </summary>
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

        /// <summary>
        /// public getter for the list containing special instructions on the milk
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// Returns a description of the Makarth Milk
        /// </summary>
        /// <returns>String describing milk</returns>
        public override string ToString()
        {
            return $"{size} Makarth Milk";
        }
    }
}
