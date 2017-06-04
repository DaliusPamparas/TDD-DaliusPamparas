using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorTests
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void SendEmptyReturnZero()
        {
            var resultat = CalculatorSt.Add("");
            Assert.AreEqual(0, resultat);


        }
        [Test]
        public void Send1Return1()
        {
            var resultat = CalculatorSt.Add("1");
            Assert.AreEqual(1, resultat);


        }
        [Test]
        public void SendStringReturnSum()
        {
            var resultat = CalculatorSt.Add("1,2,3");
            Assert.AreEqual(6, resultat);


        }
        [Test]
        public void SendStringWitdhnewLineReturnSum()
        {
            var resultat = CalculatorSt.Add("1\n3");
            Assert.AreEqual(4, resultat);


        }

        [Test]
        public void Exception_ForNegative()
        {
            TestDelegate minus = () => CalculatorSt.Add("-1");
           
            Assert.Throws<Exception>(minus);


        }

    }
}
