using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Challenges.Tests
{
    [TestClass()]
    public class Challenge2Test
    {
        /// <summary>
        /// Unit testing for the input 60 which will return the integers { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 }.
        /// </summary>
        [TestMethod()]
        public void PositiveDivisorsTest1()
        {
            var result = Challenge2.PositiveDivisors(60);
            var answer = new List<uint>() { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 };
            Assert.IsTrue(Enumerable.SequenceEqual(result, answer));
        }

        /// <summary>
        /// Unit testing for the input 42 which will return the integers { 1, 2, 3, 6, 7, 14, 21, 42 }.
        /// </summary>
        [TestMethod()]
        public void PositiveDivisorsTest2()
        {
            var result = Challenge2.PositiveDivisors(42);
            var answer = new List<uint>() { 1, 2, 3, 6, 7, 14, 21, 42 };
            Assert.IsTrue(Enumerable.SequenceEqual(result, answer));
        }
    }
}