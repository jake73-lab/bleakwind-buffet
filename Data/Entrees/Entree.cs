using System;
using System.Collections.Generic;
namespace BleakwindBuffet.Data.Entrees
{
    public class Entree : IOrderItem
    {
        public double Price { get; }
        public uint Calories { get; }
        public List<string> SpecialInstructions { get; }

        public Entree()
        {
        }
    }
}
