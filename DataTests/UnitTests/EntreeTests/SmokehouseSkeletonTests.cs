/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.True(skeleton.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            skeleton.SausageLink = false;
            Assert.False(skeleton.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            skeleton.Egg = false;
            Assert.False(skeleton.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            skeleton.HashBrowns = false;
            Assert.False(skeleton.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            skeleton.Pancake = false;
            Assert.False(skeleton.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.Equal(5.62, skeleton.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.Equal((uint) 602, skeleton.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton
            {
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
            };

            if (!includeSausage) Assert.Contains("Hold sausage link", skeleton.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", skeleton.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hashbrowns", skeleton.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancake", skeleton.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", skeleton.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            SmokehouseSkeleton skeleton = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(skeleton);
            Assert.IsAssignableFrom<Entree>(skeleton);
        }
    }
}