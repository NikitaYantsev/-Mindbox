using AreaCalculatorCT;

namespace AreaCalculatorTest

{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThirdSideIsGreaterThanFirstAndSecond()
        {
            double a = 10;
            double b = 20;
            double c = 40;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void FirstSideIsGreaterThanSecondAndThird()
        {
            double a = 40;
            double b = 10;
            double c = 20;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void SecondSideIsGreaterThanThirdAndFirst()
        {
            double a = 20;
            double b = 40;
            double c = 10;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void FirstSideIsZero()
        {
            double a = 0;
            double b = 40;
            double c = 10;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void SecondtSideIsZero()
        {
            double a = 20;
            double b = 0;
            double c = 10;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void ThirdSideIsZero()
        {
            double a = 20;
            double b = 40;
            double c = 0;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void EquilateralTriangle1()
        {
            double a = 5;
            double b = 5;
            double c = 5;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(10.825, result);
        }

        [Test]
        public void EquilateralTriangle2()
        {
            double a = 3;
            double b = 3;
            double c = 3;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(3.897, result);
        }

        [Test]
        public void UsualTriangle1()
        {
            double a = 5;
            double b = 6;
            double c = 3;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(7.483, result);
        }

        [Test]
        public void UsualTriangle2()
        {
            double a = 20;
            double b = 20;
            double c = 35;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(169.443, result);
        }

        [Test]
        public void UsualTriangle3()
        {
            double a = 10.5;
            double b = 15.3;
            double c = 14.6;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(73.325, result);
        }

        [Test]
        public void RightTriangle1()
        {
            double a = 9;
            double b = 15;
            double c = 12;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(54, result);
        }

        [Test]
        public void RightTriangle2()
        {
            double a = 15;
            double b = 8;
            double c = 17;

            double result = AreaCalculator.CalculateArea(a, b, c);

            Assert.AreEqual(60, result);
        }

        [Test]
        public void CircleIsPoint()
        {
            double a = 0;

            double result = AreaCalculator.CalculateArea(a);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void RadiusIsNegative()
        {
            double a = -10;

            double result = AreaCalculator.CalculateArea(a);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UsualCircle1()
        {
            double a = 10;

            double result = AreaCalculator.CalculateArea(a);

            Assert.AreEqual(314.159, result);
        }

        [Test]
        public void UsualCircle2()
        {
            double a = 4.5;

            double result = AreaCalculator.CalculateArea(a);

            Assert.AreEqual(63.617, result);
        }
    }
}