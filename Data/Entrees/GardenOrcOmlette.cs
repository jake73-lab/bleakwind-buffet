/*
 * Author: Jake Herman
 * Class name: GardenOrcOmlette.cs
 * Purpose: Class used to represent a Garden Orc Omlette and its toppings
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class describing the Garden Orc Omlette
    /// </summary>
    public class GardenOrcOmlette : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// public field for the price of the omlette
        /// </summary>
        public double Price => 4.57;
        /// <summary>
        /// public field for the calories of the omlette
        /// </summary>
        public uint Calories => 404;

        public string Description = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";

        private bool broccoli = true;
        /// <summary>
        /// public getter/setter flagging whether or not the omlette has broccoli in it
        /// </summary>
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
                InvokePropertyChanged("Broccoli");
            }
        }

        private bool mushrooms = true;
        /// <summary>
        /// public getter/setter flagging whether or not the omlette has mushrooms in it
        /// </summary>
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
                InvokePropertyChanged("Mushrooms");
            }
        }

        private bool tomato = true;
        /// <summary>
        /// public getter/setter flagging whether or not the omlette has tomatoes in it
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

        private bool cheddar = true;
        /// <summary>
        /// public getter/setter flagging whether or not the omlette has cheddar in it
        /// </summary>
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
                InvokePropertyChanged("Cheddar");
            }
        }

        private List<String> specialInstructions = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// list containing special instructions for preparing the omlette
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// describes the omlette
        /// </summary>
        /// <returns>string description of the omlette</returns>
        public override string ToString()
        {
            return "Garden Orc Omlette";
        }
    }
}
