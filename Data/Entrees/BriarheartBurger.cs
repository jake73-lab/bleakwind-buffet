/*
 * Author: Jake Herman
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent a Briarheart Burger and its toppings
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class describing a briarheart burger
    /// </summary>
    public class BriarheartBurger : Entree
    {
        /// <summary>
        /// public field holding the price of the burger
        /// </summary>
        public double Price => 6.32;
        /// <summary>
        /// public field containing the caloric content of the burger
        /// </summary>
        public uint Calories => 732;

        private bool bun = true;
        /// <summary>
        /// public getter/setter flagging whether or not the burger has a bun
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                if(!value)
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
        /// public getter/setter flagging whether or not the burger has ketchup on it
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
        /// public getter/setter flagging whether or not the burger has mustard on it
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
        /// public getter/setter flagging whether or not the burger has pickles
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
        /// public getter/setter flagging whether or not the burger has cheese on it
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

        private List<String> specialInstructions = new List<string>();

        /// <summary>
        /// list of special instructions for preparing the burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// summary of the burger
        /// </summary>
        /// <returns>string description of the burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
