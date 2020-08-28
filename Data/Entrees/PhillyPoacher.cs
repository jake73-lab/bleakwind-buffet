/*
 * Author: Jake Herman
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent a Philly Poacher and its toppings
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        public double Price => 7.23;
        public uint Calories => 784;

        private bool sirloin = true;
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
            }
        }

        private bool onion = true;
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
            }
        }

        private bool roll = true;
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
            }
        }

        private List<String> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
