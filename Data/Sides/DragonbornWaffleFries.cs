/*
 * Author: Jake Herman
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent a DragonbornWaffleFries and handle sizes
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class describing the Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side, INotifyPropertyChanged
    {
        public string Description = "Crispy fried potato waffle fries.";

        private Size size = Size.Small;
        /// <summary>
        /// public getter/setter for the size of the fries
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
                InvokePropertyChanged("Size");
            }
        }

        /// <summary>
        /// public getter for the price of the fries, based on size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.42;
                }
                else if (size == Size.Medium)
                {
                    return 0.76;
                }
                else
                {
                    return 0.96;
                }
            }
        }

        /// <summary>
        /// public getter for the calories of the fries, based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 77;
                }
                else if (size == Size.Medium)
                {
                    return 89;
                }
                else
                {
                    return 100;
                }
            }
        }

        private List<String> specialInstructions = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// list of special instructions for preparing the fries
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// describes the fries
        /// </summary>
        /// <returns>string description of the fries</returns>
        public override string ToString()
        {
            return $"{size} Dragonborn Waffle Fries";
        }
    }
}
