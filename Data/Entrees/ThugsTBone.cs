/*
 * Author: Jake Herman
 * Class name: ThugsTbone.cs
 * Purpose: Class used to simply represent a ThugsTbone
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class describing the thugs tbone
    /// </summary>
    public class ThugsTBone : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// public field containing the price of the thugs t bone
        /// </summary>
        public double Price => 6.44;
        /// <summary>
        /// public field containing the calories in the thugs tbone
        /// </summary>
        public uint Calories => 982;

        private List<String> specialInstructions = new List<string>();

        public string Description = "Juicy T-Bone, not much else to say.";

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// list of special instructions for preparing the thugs tbone
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// describes the thugs tbone
        /// </summary>
        /// <returns>string description of the thugs tbone</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
