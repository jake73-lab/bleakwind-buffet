/*
 * Author: Jake Herman
 * Class name: GardenOrcOmlette.cs
 * Purpose: Class used to represent a Garden Orc Omlette and its toppings
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmlette
    {
        public double Price => 4.57;
        public uint Calories => 404;

        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return Broccoli;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold Broccoli");
                }
                else
                {
                    specialInstructions.Remove("Hold Broccoli");
                }
                broccoli = value;
            }
        }

        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold mushrooms");
                }
                else
                {
                    specialInstructions.Remove("Hold mushrooms");
                }
                mushrooms = value;
            }
        }

        private bool tomato = true;
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

        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }

            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold cheddar");
                }
                else
                {
                    specialInstructions.Remove("Hold cheddar");
                }
                cheddar = value;
            }
        }

        private List<String> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public override string ToString()
        {
            return "Garden Orc Omlette";
        }
    }
}
