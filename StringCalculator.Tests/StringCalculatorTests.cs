﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorClass = StringCalculator.App.StringCalculator;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        private StringCalculatorClass _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new StringCalculatorClass();
        }

        [TestMethod]
        public void Add_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, _calculator.Add(""));
        }

        [TestMethod]
        public void Add_SingleNumber_ReturnsNumber()
        {
            Assert.AreEqual(1, _calculator.Add("1"));
        }
    }
}
