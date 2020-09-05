/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            Assert.True(omlette.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            Assert.True(omlette.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            Assert.True(omlette.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            Assert.True(omlette.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            omlette.Broccoli = false;
            Assert.False(omlette.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            omlette.Mushrooms = false;
            Assert.False(omlette.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            omlette.Tomato = false;
            Assert.False(omlette.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            omlette.Tomato = false;
            Assert.False(omlette.Tomato);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            Assert.Equal(457, omlette.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            Assert.Equal((uint) 404, omlette.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette()
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar
            };

            if (!includeBroccoli) Assert.Contains("Hold Broccoli", omlette.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", omlette.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", omlette.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", omlette.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmlette omlette = new GardenOrcOmlette();
            Assert.Equal("Garden Orc Omlette", omlette.ToString());
        }
    }
}