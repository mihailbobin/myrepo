using NUnit.Framework;
using System;
using System.Reflection.Metadata;

namespace BundleStruct.UnitTests
{
    [TestFixture]
    public class BundleTests
    {
        [Test]
        public void Constructor_ValidValues_PropertiesSet()
        {
            var b = new Bundle(500, 3);
            Assert.That(b.Banknote, Is.EqualTo(500));
            Assert.That(b.Count, Is.EqualTo(3));
        }

        [TestCase(-1)]
        [TestCase(3)]
        [TestCase(123)]
        public void Constructor_InvalidBanknote_ThrowsArgumentException(int invalidBanknote)
        {
            Assert.That(() => new Bundle(invalidBanknote, 1), Throws.ArgumentException);
        }

        [Test]
        public void Constructor_NegativeCount_ThrowsArgumentException()
        {
            Assert.That(() => new Bundle(100, -5), Throws.ArgumentException);
        }

        [Test]
        public void Sum_CorrectResult()
        {
            var b = new Bundle(200, 4);
            Assert.That(b.Sum, Is.EqualTo(800));
        }

        [TestCase(5, 10, "10 x 5 ð.")]
        [TestCase(1000, 3, "3 x 1000 ð.")]
        public void ToString_CorrectFormat(int banknote, int count, string expected)
        {
            var b = new Bundle(banknote, count);
            Assert.That(b.ToString(), Is.EqualTo(expected));
        }

        [Test]
        public void Equals_EqualBundles_True()
        {
            var b1 = new Bundle(100, 2);
            var b2 = new Bundle(100, 2);
            Assert.That(b1.Equals(b2), Is.True);
            Assert.That(b1 == b2, Is.True);
        }

        [Test]
        public void Equals_DifferentBundles_False()
        {
            var b1 = new Bundle(100, 2);
            var b2 = new Bundle(100, 3);
            Assert.That(b1.Equals(b2), Is.False);
            Assert.That(b1 != b2, Is.True);
        }

        [Test]
        public void Addition_ValidBundles_SumsCorrectly()
        {
            var b1 = new Bundle(500, 2);
            var b2 = new Bundle(500, 3);
            var result = b1 + b2;

            Assert.That(result.Banknote, Is.EqualTo(500));
            Assert.That(result.Count, Is.EqualTo(5));
        }

        [Test]
        public void Addition_DifferentBanknotes_Throws()
        {
            var b1 = new Bundle(500, 2);
            var b2 = new Bundle(100, 3);

            Assert.That(() => { var _ = b1 + b2; }, Throws.InvalidOperationException);
        }

        [Test]
        public void Subtraction_ValidBundles_SubtractsCorrectly()
        {
            var b1 = new Bundle(1000, 5);
            var b2 = new Bundle(1000, 3);
            var result = b1 - b2;

            Assert.That(result.Banknote, Is.EqualTo(1000));
            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void Subtraction_LargerSecondBundle_Throws()
        {
            var b1 = new Bundle(500, 2);
            var b2 = new Bundle(500, 5);

            Assert.That(() => { var _ = b1 - b2; }, Throws.InvalidOperationException);
        }

        [Test]
        public void Subtraction_DifferentBanknotes_Throws()
        {
            var b1 = new Bundle(500, 2);
            var b2 = new Bundle(1000, 1);

            Assert.That(() => { var _ = b1 - b2; }, Throws.InvalidOperationException);
        }
    }
}
