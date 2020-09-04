/*
 * Author: Jake Herman
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent a Thalmor Triple and its toppings
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class describing the thalmor triple
    /// </summary>
    public class ThalmorTriple
    {
        /// <summary>
        /// public field containing the price of the thalmor triple
        /// </summary>
        public double Price => 8.32;
        /// <summary>
        /// public field containing the calories in the thalmor triple
        /// </summary>
        public uint Calories => 943;

        private bool bun = true;
        /// <summary>
        /// public getter/setter flagging whether or not the thalmor triple has a bun
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
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// public getter/setter flagging whether or not the thalmor triple has ketchup
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
            }
        }

        private bool mustard = true;
        /// <summary>
        /// public getter/setter flagging whether or not the thalmor triple has mustard
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
            }
        }

        private bool pickle = true;

        /// <summary>
        /// public getter/setter flagging whether or not the thalmor triple has pickles
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
            }
        }

        private bool cheese = true;
        /// <summary>
        /// public getter/setter flagging whether or not the thalmor triple has cheese
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
            }
        }

        private bool tomato = true;
        /// <summary>
        /// public getter/setter flagging whether or not the thalmor triple has tomato
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
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// public getter/setter flagging whether or not the thalmor triple has lettuce
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
            }
        }

        private bool mayo = true;
        /// <summary>
        /// public getter/setter flagging whether or not the thalmor triple has mayo
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
            }
        }

        private bool bacon = true;
        /// <summary>
        /// public getter/setter flagging whether or not the thalmor triple has bacon
        /// </summary>
        public bool Bacon
        {
            get
            {
                return Bacon;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold bacon");
                }
                else
                {
                    specialInstructions.Remove("Hold bacon");
                }
                bacon = value;
            }
        }

        private bool egg = true;
        /// <summary>
        /// public getter/setter flagging whether or not the thalmor triple has egg
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
            }
        }

        private List<String> specialInstructions = new List<string>();

        /// <summary>
        /// list of special instructions for preparing the thalmor triple
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// describes the thalmor triple
        /// </summary>
        /// <returns>string description of the thalmor triple</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
