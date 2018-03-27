using System;
using NUnit.Framework;

namespace Ccd.GuardExample
{
    [TestFixture]
    public class GuardSpecs
    {
        private readonly string mockArgumentName = "mock";

        [Test]
        [TestCase(-1)]
        [TestCase(-5)]
        [TestCase(int.MinValue)]
        public void IsPositive_WhithNegativeValue_Should_ThrowException(int actualValue)
        {
            Assert.That(() => Guard.IsPositive(mockArgumentName, actualValue),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>()
            );
        }

        [Test]
        public void IsPositive_WhithZeroValue_Should_DoNothing()
        {
            Assert.That(() => Guard.IsPositive(mockArgumentName, 0), Throws.Nothing);
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(int.MaxValue)]
        public void IsPositive_WhithPositiveValue_Should_DoNothing(int actualValue)
        {
            Assert.That(() => Guard.IsPositive(mockArgumentName, actualValue), Throws.Nothing);
        }
    }
}