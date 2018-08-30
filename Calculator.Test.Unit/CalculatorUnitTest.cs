using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
    // Add Test:
        [Test]
        public void Add_Add2And8_Returns10()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(2,8), Is.EqualTo(10));
        }
        [Test]
        public void Add_AddMinus4And10_Return6()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(-4, 10), Is.EqualTo(6));
        }
        [Test]
        public void Add_AddMinus4AndMinus10_ReturnMinus14()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(-4, -10), Is.EqualTo(-14));
        }
    
    // Subtract Test:
        [Test]
        public void Subtract_Sub10And6_Return4()
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(10, 6), Is.EqualTo(4));
        }
        [Test]
        public void Subtract_SubMinus10And6_ReturnMinus16()
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(-10, 6), Is.EqualTo(-16));
        }
        [Test]
        public void Subtract_SubMinus10AndMinus6_ReturnMinus4()
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(-10, -6), Is.EqualTo(-4));
        }

    // Multiply Test:
        [Test]
        public void Multiply_Multi7And2_Return14()
        {
            var uut = new Calculator();
            Assert.That(uut.Multiply(7,2),Is.EqualTo(14));
        }
        [Test]
        public void Multiply_MultiMinus7And2_ReturnMinus14()
        {
            var uut = new Calculator();
            Assert.That(uut.Multiply(-7, 2), Is.EqualTo(-14));
        }
        [Test]
        public void Multiply_MultiMinus7AndMinus2_Return14()
        {
            var uut = new Calculator();
            Assert.That(uut.Multiply(-7, -2), Is.EqualTo(14));
        }

    // Power Test:
        [Test]
        public void Power_Pow2And2_Return4()
        {
            var uut = new Calculator();
            Assert.That(uut.Power(2, 2), Is.EqualTo(4));
        }
        [Test]
        public void Power_PowMinus2And2_ReturnMinus4()
        {
            var uut = new Calculator();
            Assert.That(uut.Power(-2, 2), Is.EqualTo(-4));
        }
        [Test]
        public void Power_Pow2AndMinus2_Return0point25()
        {
            var uut = new Calculator();
            Assert.That(uut.Power(2, -2), Is.EqualTo(0.25));
        }
        [Test]
        public void Power_PowMinus2AndMinus2_ReturnMinus0point25()
        {
            var uut = new Calculator();
            Assert.That(uut.Power(-2, -2), Is.EqualTo(-0.25));
        }

    }
}
