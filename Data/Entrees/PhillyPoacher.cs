/*
 * Author: Jake Herman
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent a Philly Poacher and its toppings
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class representing the philly poacher
    /// </summary>
    public class PhillyPoacher : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// public field containing the price of the philly
        /// </summary>
        public double Price => 7.23;
        /// <summary>
        /// public field containing the calories of the philly
        /// </summary>
        public uint Calories => 784;

        public string Description = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";

        private bool sirloin = true;
        /// <summary>
        /// public getter/setter flagging whether or not the philly contains sirloin
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return Sirloin;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold Sirloin");
                }
                else
                {
                    specialInstructions.Remove("Hold Sirloin");
                }
                sirloin = value;
                InvokePropertyChanged("Sirloin");
            }
        }

        private bool onion = true;
        /// <summary>
        /// public getter/setter flagging whether or not the philly contains onion
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold onion");
                }
                else
                {
                    specialInstructions.Remove("Hold onion");
                }
                onion = value;
                InvokePropertyChanged("Onion");
            }
        }

        private bool roll = true;
        /// <summary>
        /// public getter/setter flagging whether or not the philly has a roll
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold roll");
                }
                else
                {
                    specialInstructions.Remove("Hold roll");
                }
                roll = value;
                InvokePropertyChanged("Roll");
            }
        }

        private List<String> specialInstructions = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        /// <summary>
        /// list of special instructions for preparing the philly
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// describes the philly
        /// </summary>
        /// <returns>string description of the philly</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
