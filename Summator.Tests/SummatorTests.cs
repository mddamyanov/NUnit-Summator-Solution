using NUnit.Framework;
using System;


namespace Summator.Tests
{
    public class SummatorTests
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            TestContext.Progress.WriteLine("Tests started!");
        }
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Test started:" + DateTime.Now);
        }

        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });
            int expected = 12;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            long actual = Summator.Sum(new int[] { 5 });
            int expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { -7,-9 });
            int expected = -16;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] {});
            Assert.That(actual == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new int[] {2000000000, 2000000000, 2000000000, 2000000000 });
            Assert.AreEqual(8000000000, actual);
        }

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            double actual = Summator.Average(new int[] {5, 8 });
            //double expected = 6.5;
            Assert.AreEqual(6.5, actual);
        }

        [Test]
        public void Test_Average_OnePossitiveNumber()
        {
            double actual = Summator.Average(new int[] { 6 });
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_TwoNegativeNumbers()
        {
            double actual = Summator.Average(new int[] { -7, -9 });
            int expected = -8;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_BigValues()
        {
            double actual = Summator.Average(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 });
            Assert.AreEqual(2000000000, actual);
        }

        [TearDown]
        public void Teardown()
        {
            System.Console.WriteLine("Test ended:" + DateTime.Now);
        }

        [OneTimeTearDown]
        public void OnetimeTeardown()
        {
            TestContext.Progress.WriteLine("All Tests Ended!");
        }
    }
}