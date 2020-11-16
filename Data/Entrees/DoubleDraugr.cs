/*
 * Author: Jake Herman
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent a Double Draugr and its toppings
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class representing the double draugr
    /// </summary>
    public class DoubleDraugr : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// public field for the price of the draugr
        /// </summary>
        public double Price => 7.32;
        /// <summary>
        /// public field for the caloric content of the draugr
        /// </summary>
        public uint Calories => 843;

        public string Description = "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";

        private bool bun = true;
        /// <summary>
        /// public getter/setter flagging whether or not the draugr has a bun
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold bun");
                }
                else
                {
                    specialInstructions.Remove("Hold bun");
                }
                bun = value;
                InvokePropertyChanged("Bun");
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// public getter/setter flagging whether or not the draugr has ketchup on it
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold ketchup");
                }
                else
                {
                    specialInstructions.Remove("Hold ketchup");
                }
                ketchup = value;
                InvokePropertyChanged("Ketchup");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// public getter/setter flagging whether or not the draugr has mustard on it
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold mustard");
                }
                else
                {
                    specialInstructions.Remove("Hold mustard");
                }
                mustard = value;
                InvokePropertyChanged("Mustard");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// public getter/setter flagging whether or not the draugr has pickles on it
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold pickle");
                }
                else
                {
                    specialInstructions.Remove("Hold pickle");
                }
                pickle = value;
                InvokePropertyChanged("Pickle");
            }
        }

        private bool cheese = true;

        /// <summary>
        /// public getter/setter flagging whether or not the draugr has cheese on it
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold cheese");
                }
                else
                {
                    specialInstructions.Remove("Hold cheese");
                }
                cheese = value;
                InvokePropertyChanged("Cheese");
            }
        }

        private bool tomato = true;

        /// <summary>
        /// public getter/setter flagging whether or not the draugr has tomato on it
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold tomato");
                }
                else
                {
                    specialInstructions.Remove("Hold tomato");
                }
                tomato = value;
                InvokePropertyChanged("Tomato");
            }
        }

        private bool lettuce = true;

        /// <summary>
        /// public getter/setter flagging whether or not the draugr has lettuce on it
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold lettuce");
                }
                else
                {
                    specialInstructions.Remove("Hold lettuce");
                }
                lettuce = value;
                InvokePropertyChanged("Lettuce");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// public getter/setter flagging whether or not the draugr has mayo on it
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold mayo");
                }
                else
                {
                    specialInstructions.Remove("Hold mayo");
                }
                mayo = value;
                InvokePropertyChanged("Mayo");
            }
        }

        private List<String> specialInstructions = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// list of instructions for preparing the double draugr
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// describes the double draugr
        /// </summary>
        /// <returns>string description of the double draugr</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
