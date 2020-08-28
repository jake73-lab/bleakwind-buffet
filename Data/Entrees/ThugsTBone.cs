/*
 * Author: Jake Herman
 * Class name: ThugsTbone.cs
 * Purpose: Class used to simply represent a ThugsTbone
 */

using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        public double Price => 6.44;
        public uint Calories => 982;

        private List<String> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
