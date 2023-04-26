using Calculator;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2, 4, 6)]
        [TestCase(-2, 4, 2)]
        [TestCase(2, -4, -2)]
        public void Add(float x, float y, float result)
        {
            Assert.That(CalculatorHelper.Add(x, y), Is.EqualTo(result));
        }

        [Test]
        [TestCase(2, 4, -2)]
        [TestCase(-2, 4, -6)]
        [TestCase(2, -4, 6)]
        public void Subtract(float x, float y, float result)
        {
            Assert.That(CalculatorHelper.Subtract(x, y), Is.EqualTo(result));
        }

        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(-4, 2, -2)]
        [TestCase(4, -2, -2)]
        public void Divide(float x, float y, float result)
        {
            Assert.That(CalculatorHelper.Divide(x, y), Is.EqualTo(result));
        }

        [Test]
        [TestCase(10, 0)]
        [TestCase(0, 0)]
        public void DivideByZero(float n, float d)
        {
            Assert.Throws<ArgumentException>(() => CalculatorHelper.Divide(n, d));
        }

        [Test]
        [TestCase(4, 2, 8)]
        [TestCase(-4, 2, -8)]
        [TestCase(4, -2, -8)]
        public void Multiply(float x, float y, float result)
        {
            Assert.That(CalculatorHelper.Multiply(x, y), Is.EqualTo(result));
        }
    }
}