using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class Drink : IOrderItem
    {
        public Size Size { get; set; }
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> SpecialInstructions { get; set; }

        public Drink()
        {
        }
    }
}
