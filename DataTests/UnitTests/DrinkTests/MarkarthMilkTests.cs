﻿/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.False(milk.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.Equal(Size.Small, milk.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Ice = true;
            Assert.True(milk.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = Size.Medium;
            Assert.Equal(Size.Medium, milk.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.Equal(price, milk.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.Equal(cal, milk.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk milk = new MarkarthMilk()
            {
                Ice = includeIce
            };

            if (!includeIce) Assert.Contains("Add ice", milk.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk milk = new MarkarthMilk()
            {
                Size = size
            };

            Assert.Equal(name, milk.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(milk);
            Assert.IsAssignableFrom<Drink>(milk);
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            MarkarthMilk milk = new MarkarthMilk();

            Assert.PropertyChanged(milk, "Size", () =>
            {
                milk.Size = Size.Small;
            });

            Assert.PropertyChanged(milk, "Size", () =>
            {
                milk.Size = Size.Medium;
            });

            Assert.PropertyChanged(milk, "Size", () =>
            {
                milk.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            MarkarthMilk milk = new MarkarthMilk();

            Assert.PropertyChanged(milk, "Ice", () =>
            {
                milk.Ice = true;
            });

            Assert.PropertyChanged(milk, "Ice", () =>
            {
                milk.Ice = false;
            });
        }

    }
}