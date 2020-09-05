using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        private Size size = Size.Small;
        /// <summary>
        /// public getter/setter for size of apple juice
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
        /// public getter for price of apple juice, based on size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return .62;
                }
                else if (size == Size.Medium)
                {
                    return .87;
                }
                else
                {
                    return 1.01;
                }
            }
        }

        /// <summary>
        /// public getter for calories of apple juice, based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 44;
                }
                else if (size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
                }
            }
        }

        private bool ice = false;
        /// <summary>
        /// public getter/setter flagging whether or not the apple juice has ice, false by default
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
        /// public getter for special instructions list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// gets information of apple juice instance as a string
        /// </summary>
        /// <returns>description of apple juice</returns>
        public override string ToString()
        {
            return $"{size} Aretino Apple Juice";
        }
    }
}
