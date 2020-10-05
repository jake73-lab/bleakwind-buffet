﻿/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.Equal(Size.Small, soda.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda soda = new SailorSoda();
            soda.Ice = false;
            Assert.False(soda.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = Size.Medium;
            Assert.Equal(Size.Medium, soda.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda soda = new SailorSoda();
            soda.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, soda.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = size;
            Assert.Equal(price, soda.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = size;
            Assert.Equal(cal, soda.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda soda = new SailorSoda()
            {
                Ice = includeIce
            };

            if (!includeIce) Assert.Contains("Hold ice", soda.SpecialInstructions);

        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda soda = new SailorSoda()
            {
                Size = size,
                Flavor = flavor
            };

            Assert.Equal(name, soda.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            SailorSoda soda = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(soda);
            Assert.IsAssignableFrom<Drink>(soda);
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            SailorSoda soda = new SailorSoda();

            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Small;
            });

            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Medium;
            });

            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            SailorSoda soda = new SailorSoda();

            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = true;
            });

            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }


        [Fact]
        public void ChangingFlavorNotifiesFlavorProperty()
        {
            SailorSoda soda = new SailorSoda();

            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.Cherry;
            });

            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.Blackberry;
            });

            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.Grapefruit;
            });

            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.Peach;
            });

            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.Watermelon;
            });
        }
    }
}
