using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class Side : IOrderItem
    {
        public double Price { get; }
        public uint Calories { get; }
        public List<string> SpecialInstructions { get; }

        public Side()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
