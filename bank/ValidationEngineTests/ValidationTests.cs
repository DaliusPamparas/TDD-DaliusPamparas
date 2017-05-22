using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ValidationEngineTests
{
    [TestFixture]
    class ValidationTests
    {
        [Test]
        public void TrueForValidAddress()
        {
            var sut = new ValidationEngine.ValidationEngine();

            var result = sut.Validate("dalius.pamparas@test.se");

            Assert.IsTrue(result, "Email is no valid !");
        }
        [Test]
        public void NoAtSingnInEmail()
        {
            var sut = new ValidationEngine.ValidationEngine();

            var result = sut.Validate("daliustestgddf.se");

            Assert.IsFalse(result, "Email validation without @ no working!");
        }
        [Test]
        public void NoPointInEmail()
        {
            var sut = new ValidationEngine.ValidationEngine();

            var result = sut.Validate("daliust@estgddfse");

            Assert.IsFalse(result, "Email validation without . id no working!");
        }
        [Test]
        public void NoEmptyEmailValue()
        {
            var sut = new ValidationEngine.ValidationEngine();

            
            var result = sut.Validate("");
            Assert.IsFalse(result, "Email validation with empty value no working!");
        }
    }
}
