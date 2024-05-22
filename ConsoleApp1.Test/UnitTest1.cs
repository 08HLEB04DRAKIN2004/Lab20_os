using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MaxTest_PositiveNumbers()
        {
            double a = 5.0;
            double b = 10.0;
            double c = 3.0;
            double expectedMax = 10.0;

            double actualMax = Program.Max(a, b, c);

            Assert.AreEqual(expectedMax, actualMax, "Максимальное значение неверно");
        }

        [TestMethod()]
        public void MinTest_PositiveNumbers()
        {
            double a = 5.0;
            double b = 10.0;
            double c = 3.0;
            double expectedMin = 3.0;

            double actualMin = Program.Min(a, b, c);

            Assert.AreEqual(expectedMin, actualMin, "Минимальное значение неверно");
        }

        [TestMethod()]
        public void MaxTest_NegativeNumbers()
        {
            double a = -5.0;
            double b = -10.0;
            double c = -3.0;
            double expectedMax = -3.0;

            double actualMax = Program.Max(a, b, c);

            Assert.AreEqual(expectedMax, actualMax, "Максимальное значение неверно");
        }

        [TestMethod()]
        public void MinTest_NegativeNumbers()
        {
            double a = 0.001;
            double b = 0.2;
            double c = 0.3;
            double expectedMin = 0.0001;

            double actualMin = Program.Min(a, b, c);

            Assert.AreEqual(expectedMin, actualMin, "Минимальное значение неверно");
        }

        [TestMethod()]
        public void MaxTest_MixedNumbers()
        {
            double a = -5.0;
            double b = 10.0;
            double c = -3.0;
            double expectedMax = 10.0;

            double actualMax = Program.Max(a, b, c);

            Assert.AreEqual(expectedMax, actualMax, "Максимальное значение неверно");
        }

        [TestMethod()]
        public void MinTest_MixedNumbers()
        {
            double a = -5.0;
            double b = 10.0;
            double c = -3.0;
            double expectedMin = -5.0;

            double actualMin = Program.Min(a, b, c);

            Assert.AreEqual(expectedMin, actualMin, "Минимальное значение неверно");
        }

        [TestMethod()]
        public void MaxTest_ZeroAndPositiveNumbers()
        {
            double a = 0.0;
            double b = 10.0;
            double c = 3.0;
            double expectedMax = 10.0;

            double actualMax = Program.Max(a, b, c);

            Assert.AreEqual(expectedMax, actualMax, "Максимальное значение неверно");
        }

        [TestMethod()]
        public void MinTest_ZeroAndPositiveNumbers()
        {
            double a = 0.0;
            double b = 10.0;
            double c = 3.0;
            double expectedMin = 0.0;

            double actualMin = Program.Min(a, b, c);

            Assert.AreEqual(expectedMin, actualMin, "Минимальное значение неверно");
        }

        [TestMethod()]
        public void MaxTest_OneNumberRepeats()
        {
            double a = 5.0;
            double b = 10.0;
            double c = 5.0;
            double expectedMax = 10.0;

            double actualMax = Program.Max(a, b, c);

            Assert.AreEqual(expectedMax, actualMax, "Максимальное значение неверно");
        }

        [TestMethod()]
        public void MinTest_OneNumberRepeats()
        {
            double a = 5.0;
            double b = 10.0;
            double c = 5.0;
            double expectedMin = 5.0;

            double actualMin = Program.Min(a, b, c);

            Assert.AreEqual(expectedMin, actualMin, "Минимальное значение неверно");
        }
    }
}
