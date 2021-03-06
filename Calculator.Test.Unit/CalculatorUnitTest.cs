﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("John Romby")]
    public class CalculatorUnitTest
    {
        private Calculator _uut;

    // Test Setup:
        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

    // Add Test:
//        [TestCase(2, 8, ExpectedResult = 10)]     // Could not get this one to work in my case.
        [TestCase(2, 8, 10)]
        [TestCase(-2, 8, 6)]
        [TestCase(2, -8, -6)]
        [TestCase(-2, -8, -10)]
        public void Add_Test(double a,double b, double result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }
    
    // Subtract Test:
        [TestCase(10, 6, 4)]
        [TestCase(-10, 6, -16)]
        [TestCase(10, -6, 16)]
        [TestCase(-10, -6, -4)]
        public void Subtract_Test(double a, double b, double result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }

    // Multiply Test:
        [TestCase(7, 2, 14)]
        [TestCase(-7, 2, -14)]
        [TestCase(7, -2, -14)]
        [TestCase(-7, -2, 14)]
        public void Multiply_Test(double a, double b, double result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }

    // Power Test:
        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, 4)]
        [TestCase(2, -2, 0.25)]
        [TestCase(-2, -2, 0.25)]
        [TestCase(2, 3, 8)]
        [TestCase(-2, 3, -8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        public void Power_Test(double a, double b, double result)
        {
            Assert.That(_uut.Power(a, b), Is.EqualTo(result));
        }
    }
}
