using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges.Tests
{
    [TestClass()]
    public class Challenge7Test
    {
        [TestMethod()]
        public void IntersectionTest1()
        {
            var arrA = new int[] { 12, 13, 16, 18, 22, 45, 89, 99, 101, 102, 103, 104, 234 };
            var arrB = new int[] { 14, 15, 18, 19, 20, 21, 22, 23, 24, 25, 44, 45, 46, 98, 99, 100, 101, 104, 105, 200 };
            var result = Challenge7.Intersection(arrA, arrB);
            var answer = new int[] { 18, 22, 45, 99, 101, 104 };
            Assert.IsTrue(Challenge7.CompareArrays(result, answer));
        }
 
        [TestMethod()]
        public void IntersectionTest2()
        {
            var arrA = new int[] { -144, -121, -100, -81, -64, -49, -36, -25, -16, -9, -4, -1, 0, 1, 8, 27, 64, 125, 216, 343, 512, 729 };
            var arrB = new int[] { -150, -149, -148, -147, -146, -145, -144, -143, -142, -141, -140, -120, -100, -75, -50, -25, 0, 8, 16, 32 };
            var result = Challenge7.Intersection(arrA, arrB);
            var answer = new int[] { -144, -100, -25, 0, 8 };
            Assert.IsTrue(Challenge7.CompareArrays(result, answer));
        }

        [TestMethod()]
        public void IntersectionTest3()
        {
            var arrA = new int[] { -22, 22, 44, 55, 66, 77, 88, 99 };
            var arrB = new int[] { 0, 1, 2, 3, 4 };
            var result = Challenge7.Intersection(arrA, arrB);
            var answer = new int[0];
            Assert.IsTrue(Challenge7.CompareArrays(result, answer));
        }

        [TestMethod()]
        public void IntersectionTest4()
        {
            var arrA = new int[] { -22, 22, 44, 55, 66, 77, 88, 99 };
            var arrB = new int[0];
            var result = Challenge7.Intersection(arrA, arrB);
            var answer = new int[0];
            Assert.IsTrue(Challenge7.CompareArrays(result, answer));
        }

        [TestMethod()]
        public void IntersectionTest5()
        {
            var arrA = new int[0];
            var arrB = new int[] { 0, 1, 2, 3, 4 };
            var result = Challenge7.Intersection(arrA, arrB);
            var answer = new int[0];
            Assert.IsTrue(Challenge7.CompareArrays(result, answer));
        }

        [TestMethod()]
        public void IntersectionTest6()
        {
            int[] arrA = null;
            var arrB = new int[] { 0, 1, 2, 3, 4 };
            var result = Challenge7.Intersection(arrA, arrB);
            var answer = new int[0];
            Assert.IsTrue(Challenge7.CompareArrays(result, answer));
        }
    }
}