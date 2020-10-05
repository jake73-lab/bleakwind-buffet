/*
 * Author: Jake Herman
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent a Smokehouse Skeleton and its toppings
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class describing the smokehouse skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// public field containing the price of the smokehouse skeleton
        /// </summary>
        public double Price => 5.62;
        /// <summary>
        /// public field containing the calories of the smokehouse skeleton
        /// </summary>
        public uint Calories => 602;

        private bool sausageLink = true;
        /// <summary>
        /// public getter/setter flagging whether or not the smokehouse skeleton has a sausage link
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold sausage link");
                }
                else
                {
                    specialInstructions.Remove("Hold sausage link");
                }
                sausageLink = value;
                InvokePropertyChanged("Sausage Link");
            }
        }

        private bool egg = true;
        /// <summary>
        /// public getter/setter flagging whether or not the smokehouse skeleton has an egg
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold egg");
                }
                else
                {
                    specialInstructions.Remove("Hold egg");
                }
                egg = value;
                InvokePropertyChanged("Egg");
            }
        }

        private bool hashBrowns = true;
        /// <summary>
        /// public getter/setter flagging whether or not the smokehouse skeleton has hash browns
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold hash browns");
                }
                else
                {
                    specialInstructions.Remove("Hold hash browns");
                }
                hashBrowns = value;
                InvokePropertyChanged("Hash Browns");
            }
        }

        private bool pancake = true;

        /// <summary>
        /// public getter/setter flagging whether or not the smokehouse skeleton has a pancake
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold pancake");
                }
                else
                {
                    specialInstructions.Remove("Hold pancake");
                }
                pancake = value;
                InvokePropertyChanged("Pancake");
            }
        }

        private List<String> specialInstructions = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// list of special instructions for preparing the smokehouse skeleton
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// describes the smokehouse skeleton
        /// </summary>
        /// <returns>string description of the smokehouse skeleton</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
