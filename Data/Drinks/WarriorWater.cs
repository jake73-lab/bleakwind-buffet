/*
 * Author: Jake Herman
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent a Warrior Water and handle sizes
 */

using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public double Price
        {
            get
            {
                return 0.00;
            }
        }

        public uint Calories
        {
            get
            {
                return 0;
            }
        }

        private bool ice = true;
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
            }
        }

        private bool lemon = false;
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
            }
        }

        private List<String> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public override string ToString()
        {
            return $"{size} Warrior Water";
        }
    }
}
