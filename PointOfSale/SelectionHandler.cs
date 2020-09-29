using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    public class SelectionHandler : EventArgs
    {
        public IOrderItem item;
    }
}
