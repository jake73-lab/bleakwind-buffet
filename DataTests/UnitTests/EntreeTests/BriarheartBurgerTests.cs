﻿/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Bun = false;
            Assert.False(burger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Cheese = false;
            Assert.False(burger.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal(6.32, burger.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal((uint) 732, burger.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger burger = new BriarheartBurger()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese
            };

            if (!includeBun) Assert.Contains("Hold bun", burger.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", burger.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", burger.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", burger.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", burger.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", burger.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(burger);
            Assert.IsAssignableFrom<Entree>(burger);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();

            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = true;
            });

            Assert.PropertyChanged(burger, "Ice", () =>
            {
                burger.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();

            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = true;
            });

            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = false;
            });
        }


        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();

            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = true;
            });

            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();

            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = true;
            });

            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeeseNotifiesCheeseProperty()
        {
            BriarheartBurger burger = new BriarheartBurger();

            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = true;
            });

            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Cheese = false;
            });
        }
    }
}