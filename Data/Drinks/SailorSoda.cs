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
    /// <summary>
    /// class representing a Sailor Soda
    /// </summary>
    public class SailorSoda : Drink
    {
        private Size size = Size.Small;
        /// <summary>
        /// public getter/setter for the Sailor Soda
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

        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// public getter/setter for the flavor of the Sailor Soda defaulted to cherry
        /// </summary>
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

        /// <summary>
        /// public getter for the price of the sailor soda, based on size
        /// </summary>
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

        /// <summary>
        /// public getter for the calories of the sailor soda, based on size
        /// </summary>
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
        /// <summary>
        /// public getter/setter flagging whether or not the sailor soda has ice, defaulted to true
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

        /// <summary>
        /// a list of special instructions for preparing the Sailor Soda
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// returns a description of the sailor soda
        /// </summary>
        /// <returns>a string decribing the size and flavor of the soda</returns>
        public override string ToString()
        {
            return $"{size} {flavor} Sailor Soda";
        }
    }
}
