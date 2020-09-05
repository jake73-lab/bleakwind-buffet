﻿/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.True(thalmor.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.True(thalmor.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.True(thalmor.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.True(thalmor.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.True(thalmor.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.True(thalmor.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.True(thalmor.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.True(thalmor.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.True(thalmor.Bacon); 
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.True(thalmor.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            thalmor.Bun = false;
            Assert.False(thalmor.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            thalmor.Ketchup = false;
            Assert.False(thalmor.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            thalmor.Mustard = false;
            Assert.False(thalmor.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            thalmor.Pickle = false;
            Assert.False(thalmor.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            thalmor.Cheese = false;
            Assert.False(thalmor.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            thalmor.Tomato = false;
            Assert.False(thalmor.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            thalmor.Lettuce = false;
            Assert.False(thalmor.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            thalmor.Mayo = false;
            Assert.False(thalmor.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            thalmor.Bacon = false;
            Assert.False(thalmor.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            thalmor.Egg = false;
            Assert.False(thalmor.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.Equal(832, thalmor.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.Equal((uint)943, thalmor.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple thalmor = new ThalmorTriple()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo,
                Bacon = includeBacon,
                Egg = includeEgg
            };

            if (!includeBun) Assert.Contains("Hold bun", thalmor.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", thalmor.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", thalmor.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", thalmor.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", thalmor.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", thalmor.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", thalmor.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", thalmor.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", thalmor.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", thalmor.ToString());
        }
    }
}