using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        double Price { get; }
        uint Calories { get; }
        List<string> SpecialInstructions { get; }
    }
}
