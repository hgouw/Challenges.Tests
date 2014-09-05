using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Challenges.Tests
{
    [TestClass()]
    public class Challenge3Test
    {
        /// <summary>
        /// Unit testing for the invalid inputs (2, 3, -4) which contains a negative value and will raise the InvalidTriangleException.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void TriangleAreaTest1()
        {
            double area = Challenge3.TriangleArea(2, 3, -4);
        }

        /// <summary>
        /// Unit testing for the invalid inputs (2, 0, 4) which cannot form a triangle and will raise the InvalidTriangleException.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void TriangleAreaTest2()
        {
            double area = Challenge3.TriangleArea(2, 0, 4);
        }

        /// <summary>
        /// Unit testing for the valid inputs (7, 10, 5) which will return an area of 16.248076809271922.
        /// </summary>
        [TestMethod()]
        public void TriangleAreaTest3()
        {
            Assert.IsTrue(Challenge3.TriangleArea(7, 10, 5) == 16.248076809271922);
        }
    }
}