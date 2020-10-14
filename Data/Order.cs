using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BleakwindBuffet.Data
{
    public class Order : ICollection, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public ICollection<IOrderItem> order;
        public int OrderNumber;

        static int nextOrderNumber;

        public Order()
        {
            order = new List<IOrderItem>();
            OrderNumber = nextOrderNumber;
            nextOrderNumber++;
        }

        private double salesTax = .12;

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public double SalesTaxRate
        {
            get
            {
                return salesTax;
            }

            set
            {
                salesTax = value;
                InvokePropertyChanged("SalesTaxRate");
            }
        }

        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in order)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        public double Tax
        {
            get
            {
                return Subtotal * SalesTaxRate;
            }
        }

        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }

        public uint Calories
        {
            get
            {
                uint total = 0;
                foreach(IOrderItem item in order)
                {
                    total += item.Calories;
                }
                return total;
            }
        }

        protected void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public int Count => order.Count;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void Add(IOrderItem item)
        {
            order.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            InvokePropertyChanged("Subtotal");
            InvokePropertyChanged("Tax");
            InvokePropertyChanged("Total");
            InvokePropertyChanged("Calories");
            item.PropertyChanged += ItemChanges;
        }

        public void Remove(IOrderItem item)
        {
            order.Remove(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
            InvokePropertyChanged("Subtotal");
            InvokePropertyChanged("Tax");
            InvokePropertyChanged("Total");
            InvokePropertyChanged("Calories");
        }

        private void ItemChanges(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            if (e.PropertyName == "Calories") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return order.GetEnumerator();
        }
    }
}
