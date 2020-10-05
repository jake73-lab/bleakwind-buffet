/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;


namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.Equal(Size.Small, miraak.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = Size.Medium;
            Assert.Equal(Size.Medium, miraak.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.Equal(new List<string>(), miraak.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = size;
            Assert.Equal(price, miraak.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = size;
            Assert.Equal(calories, miraak.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = size;
            Assert.Equal(name, miraak.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(miraak);
            Assert.IsAssignableFrom<Side>(miraak);
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            FriedMiraak miraak = new FriedMiraak();

            Assert.PropertyChanged(miraak, "Size", () =>
            {
                miraak.Size = Size.Small;
            });

            Assert.PropertyChanged(miraak, "Size", () =>
            {
                miraak.Size = Size.Medium;
            });

            Assert.PropertyChanged(miraak, "Size", () =>
            {
                miraak.Size = Size.Large;
            });
        }
    }
}