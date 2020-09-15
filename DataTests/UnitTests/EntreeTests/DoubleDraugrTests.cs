/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.True(draugr.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.True(draugr.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.True(draugr.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.True(draugr.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.True(draugr.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.True(draugr.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.True(draugr.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.True(draugr.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            draugr.Bun = false;
            Assert.False(draugr.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            draugr.Ketchup = false;
            Assert.False(draugr.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            draugr.Mustard = false;
            Assert.False(draugr.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            draugr.Pickle = false;
            Assert.False(draugr.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            draugr.Cheese = false;
            Assert.False(draugr.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            draugr.Tomato = false;
            Assert.False(draugr.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            draugr.Lettuce = false;
            Assert.False(draugr.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            draugr.Mayo = false;
            Assert.False(draugr.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.Equal(7.32, draugr.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.Equal((uint) 843, draugr.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr burger = new DoubleDraugr()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo
            };

            if (!includeBun) Assert.Contains("Hold bun", burger.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", burger.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", burger.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", burger.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", burger.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold mustard", burger.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold pickle", burger.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold cheese", burger.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.Equal("Double Draugr", draugr.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            DoubleDraugr draugr = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(draugr);
            Assert.IsAssignableFrom<Entree>(draugr);
        }
    }
}