using NUnit.Framework;
using System;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //int? number;

            //number == number ?? 12;

            int? a = 12;

            a = a ?? 34;

            if (a is int valueOfA)
            {
                Console.WriteLine($"a is {valueOfA}");
            }
            else
            {
                Console.WriteLine("a does not have a value");
            }

            Assert.Pass();
        }
    }
}