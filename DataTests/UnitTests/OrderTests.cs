using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void NewOrderShouldUpdateOrderNumber()
        {
            Order orderOne = new Order();
            Assert.Equal(1, orderOne.OrderNumber);
            Order orderTwo = new Order();
            Assert.Equal(2, orderOne.OrderNumber);
        }

        [Fact]
        public void AddingItemShouldUpdateSubtotal()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            order.Add(burger);
            Assert.Equal(burger.Price, order.Subtotal);
        }

        [Fact]
        public void AddingItemShouldUpdateTax()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            order.Add(burger);
            Assert.Equal(burger.Price * order.SalesTaxRate, order.Tax);
        }

        [Fact]
        public void AddingItemShouldUpdateTotal()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            order.Add(burger);
            Assert.Equal((burger.Price * order.SalesTaxRate) + burger.Price, order.Total);
        }

        [Fact]
        public void AddingItemShouldNotifySubtotalProperty()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(burger);
            });
        }

        [Fact]
        public void AddingItemShouldNotifyTotalProperty()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(burger);
            });
        }

        [Fact]
        public void AddingItemShouldNotifyCaloriesProperty()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(burger);
            });
        }

        [Fact]
        public void AddingItemShouldNotifyTaxProperty()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(burger);
            });
        }

        [Fact]
        public void RemovingItemShouldNotifySubtotalProperty()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            order.Add(burger);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(burger);
            });
        }

        [Fact]
        public void RemovingItemShouldNotifyTotalProperty()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            order.Add(burger);
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Remove(burger);
            });
        }

        [Fact]
        public void RemovingItemShouldNotifyTaxProperty()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            order.Add(burger);
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(burger);
            });
        }
    }
}
