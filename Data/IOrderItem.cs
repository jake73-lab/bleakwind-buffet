using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        double Price { get; }
        uint Calories { get; }
        List<string> SpecialInstructions { get; }
    }
}
