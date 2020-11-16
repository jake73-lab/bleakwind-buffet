/*
 * Author: Jake Herman
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent a Fried Miraak and handle sizes
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class describing Fried Miraak
    /// </summary>
    public class FriedMiraak : Side, INotifyPropertyChanged
    {
        public string Description = "Perfectly prepared hash brown pancakes.";

        private Size size = Size.Small;
        /// <summary>
        /// public getter/setter for the size of the miraak
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
        /// public getter/setter for the price of the miraak, based on size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.78;
                }
                else if (size == Size.Medium)
                {
                    return 2.01;
                }
                else
                {
                    return 2.88;
                }
            }
        }

        /// <summary>
        /// public getter/setter for the calories of the miraak, based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 151;
                }
                else if (size == Size.Medium)
                {
                    return 236;
                }
                else
                {
                    return 306;
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
        /// list of special instructions for preparing the miraak
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// describes the fried miraak
        /// </summary>
        /// <returns>string description of fried miraak</returns>
        public override string ToString()
        {
            return $"{size} Fried Miraak";
        }
    }
}
