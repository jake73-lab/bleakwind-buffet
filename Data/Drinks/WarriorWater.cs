/*
 * Author: Jake Herman
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent a Warrior Water and handle sizes
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class describing an instance of warrior water
    /// </summary>
    public class WarriorWater : Drink, INotifyPropertyChanged
    {
        private Size size = Size.Small;
        /// <summary>
        /// public getter/setter for the water's size
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
        /// public getter for the price of the water
        /// </summary>
        public double Price
        {
            get
            {
                return 0.00;
            }
        }

        /// <summary>
        /// public getter for the calories in the water
        /// </summary>
        public uint Calories
        {
            get
            {
                return 0;
            }
        }

        private bool ice = true;
        /// <summary>
        /// public getter/setter flagging whether or not the water contains ice 
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
                InvokePropertyChanged("Ice");
            }
        }

        private bool lemon = false;
        /// <summary>
        /// public getter/setter flagging whether or not the water has a lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }

            set
            {
                if (!value)
                {

                    specialInstructions.Add("add lemon");
                }
                else
                {
                    specialInstructions.Remove("add lemon");
                }
                lemon = value;
                InvokePropertyChanged("Lemon");
            }
        }

        private List<String> specialInstructions = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// public getter for the list of special instructions on preparing the water
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// a description of the milkshake
        /// </summary>
        /// <returns>a string describing the water</returns>
        public override string ToString()
        {
            return $"{size} Warrior Water";
        }
    }
}
