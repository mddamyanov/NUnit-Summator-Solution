using NUnit.Framework;
using System;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Console.WriteLine("Tests strarted!");
        }

        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Tests started: " + DateTime.Now);
        }

        [Test]
        public void Test_Sum_Two_Positive_Numbers()
        {
            long actual = Summator.Sum(new int[] {1, 13 });
            Assert.AreEqual(14, actual);
        }

        [Test]
        public void Test_Sum_Two_Negative_Numbers()
        {
            long actual = Summator.Sum(new int[] { -1, -20 });
            Assert.AreEqual(-21, actual);
        }

        [Test]
        public void Test_Sum_Positive_And_Negative_Nubmers()
        {
            long actual = Summator.Sum(new int[] { 10, -20 });
            Assert.AreEqual(-10, actual);
        }

        [Test]
        public void Test_Sum_Negative_And_Positive_Numbers()
        {
            long actual = Summator.Sum(new int[] { -15, 10 });
            Assert.AreEqual(-5, actual);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new int[] {2000000000, 2000000000 });
            Assert.AreEqual(4000000000, actual);
        }

        [Test]
        public void Test_Sum_More_Positive_Numbers()
        {
            long actual = Summator.Sum(new int[] {1, 7, 25, 30});
            Assert.AreEqual(63, actual);
        }

        [Test]
        public void Test_Sum_More_Negative_Numbers()
        {
            long actual = Summator.Sum(new int[] { -1, -7, -25, -30 });
            Assert.AreEqual(-63, actual);
        }

        [Test]
        public void Test_Sum_More_Negative_And_Positive_Numbers()
        {
            long actual = Summator.Sum(new int[] { -1, 7, -25, 30 });
            Assert.AreEqual(11, actual);
        }

        [Test]
        public void Test_Sum_Empty_Array()
        {
            long actual = Summator.Sum(new int[] { });
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Test_Average_Two_Positive_Numbers()
        {
            double actual = Summator.Average(new int[] {10, 5 });
            Assert.AreEqual(7.5, actual);
        }

        [Test]
        public void Test_Average_Two_Negative_Numbers()
        {
            double actual = Summator.Average(new int[] { -15, -10 });
            Assert.AreEqual(-12.5, actual);
        }

        [Test]
        public void Test_Average_Positive_And_Negative_Numbers()
        {
            double actual = Summator.Average(new int[] { -10, 20 });
            Assert.AreEqual(5, actual);
        }

        [Test]
        public void Test_Average_More_Positive_Numbers()
        {
            double actual = Summator.Average(new int[] { 1, 7, 25, 30 });
            Assert.AreEqual(15.75, actual);
        }

        [Test]
        public void Test_Average_More_Negative_Numbers()
        {
            double actual = Summator.Average(new int[] { -1, -7, -25, -30 });
            Assert.AreEqual(-15.75, actual);
        }

        [Test]
        public void Test_Average_More_Negative_And_Positive_Numbers()
        {
            double actual = Summator.Average(new int[] { -1, 7, -25, 30 });
            Assert.AreEqual(2.75, actual);
        }

        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("Tests ended: " + DateTime.Now);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            TestContext.Progress.WriteLine("All tests ended!");
        }
    }
}