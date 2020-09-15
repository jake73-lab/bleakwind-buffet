/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.True(philly.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Sirloin = false;
            Assert.False(philly.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Onion = false;
            Assert.False(philly.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher philly = new PhillyPoacher();
            philly.Roll = false;
            Assert.False(philly.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal(7.23, philly.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal((uint) 784, philly.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher philly = new PhillyPoacher()
            {
                Sirloin = includeSirloin,
                Onion = includeOnion,
                Roll = includeRoll,
            };

            if (!includeSirloin) Assert.Contains("Hold Sirloin", philly.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onion", philly.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", philly.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.Equal("Philly Poacher", philly.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            PhillyPoacher philly = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(philly);
            Assert.IsAssignableFrom<Entree>(philly);
        }
    }
}