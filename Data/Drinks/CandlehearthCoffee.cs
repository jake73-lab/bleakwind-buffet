/*
 * Author: Jake Herman
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth Coffee and handle sizes
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public string Description = "Fair trade, fresh ground dark roast coffee.";

    /// <summary>
    /// Class to represent Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        private Size size = Size.Small;
        /// <summary>
        /// public getter/setter for size of coffee
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
        /// public getter for price of coffee, based on size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return .75;
                }
                else if (size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }
        }

        /// <summary>
        /// public getter for calories of coffee, based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 7;
                }
                else if (size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }

        private bool ice = false;
        /// <summary>
        /// public getter/setter flagging whether or not the coffee is iced, false by default
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
                InvokePropertyChanged("Ice");
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// public getter/setter flagging whether or not the coffee has room for cream, false by default
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Add cream");
                }
                else
                {
                    specialInstructions.Remove("Add cream");
                }
                roomForCream = value;
                InvokePropertyChanged("Cream");
            }
        }

        private bool decaf = false;
        /// <summary>
        /// public getter/setter flagging whether or not the coffee is decaf, false by default
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }

            set
            {
                decaf = value;
                InvokePropertyChanged("Decaf");
            }
        }

        private List<String> specialInstructions = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// public getter for special instructions list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// gets information of coffee instance as a string
        /// </summary>
        /// <returns>size and whether or not coffee is decaf</returns>
        public override string ToString()
        {
            if(decaf)
            {
                return $"{size} Decaf Candlehearth Coffee";
            }
            else
            {
                return $"{size} Candlehearth Coffee";
            }
        }
    }
}
