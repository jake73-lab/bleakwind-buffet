using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using System.Net.Sockets;
using System.Collections.Specialized;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public Drink drink
        {
            get { return drink; }
            set
            {
                InvokePropertyChanged("drink");
            }
        }

        public Entree entree
        {
            get { return entree; }
            set
            {
                InvokePropertyChanged("entree");
            }
        }

        public Side side
        {
            get { return side; }
            set
            {
                InvokePropertyChanged("side");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Combo(Drink _drink, Entree _entree, Side _side)
        {
            drink = _drink;
            side = _side;
            entree = _entree;
        }

        private uint calories;
        public uint Calories
        {
            get
            {
                return drink.Calories + entree.Calories + side.Calories;
            }

            set
            {
                calories = value;
                InvokePropertyChanged("Calories");
            }
        }

        private double price;
        public double Price
        {
            get
            {
                return entree.Price + drink.Price + side.Price;
            }

            set
            {
                price = value;
                InvokePropertyChanged("Price");
            }
        }

        private List<string> specialInstructions;
        public List<string> SpecialInstructions
        {
            get
            {
                specialInstructions.Add(entree.ToString());
                specialInstructions.Add(side.ToString());
                specialInstructions.Add(drink.ToString());
                return specialInstructions;
            }
        }

        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
