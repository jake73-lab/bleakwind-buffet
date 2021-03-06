﻿/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Equal(6.44, tbone.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Equal((uint) 982, tbone.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Empty(tbone.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tbone.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tbone);
            Assert.IsAssignableFrom<Entree>(tbone);
        }
    }
}