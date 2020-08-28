/*
 * Author: Jake Herman
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent a Smokehouse Skeleton and its toppings
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        public double Price => 5.62;
        public uint Calories => 602;

        private bool sausageLink = true;
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
            }
        }

        private bool egg = true;
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

        private bool hashBrowns = true;
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
            }
        }

        private bool pancake = true;
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
            }
        }

        private List<String> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
