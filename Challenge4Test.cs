using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges.Tests
{
    [TestClass()]
    public class Challenge4Test
    {
        /// <summary>
        /// Unit testing for the inputs { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 } which will return the integers { 5, 4 }.
        /// </summary>
        [TestMethod()]
        public void CommonTest1()
        {
            var result = Challenge4.Common(new int[] { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 });
            var answer = new int[] { 5, 4 };
            Assert.IsTrue(Enumerable.SequenceEqual(result, answer));
        }

        /// <summary>
        /// Unit testing for the inputs { 1, 2, 3, 4, 5, 1, 6, 7 } which will return the integers { 1 }.
        /// </summary>
        [TestMethod()]
        public void CommonTest2()
        {
            var result = Challenge4.Common(new int[] { 1, 2, 3, 4, 5, 1, 6, 7 });
            var answer = new int[] { 1 };
            Assert.IsTrue(Enumerable.SequenceEqual(result, answer));
        }
        [TestMethod()]

        /// <summary>
        /// Unit testing for the inputs { 1, 2, 3, 4, 5, 6, 7 } which will return the integers { 1, 2, 3, 4, 5, 6, 7 }.
        /// </summary>
        public void CommonTest3()
        {
            var result = Challenge4.Common(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            var answer = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.IsTrue(Enumerable.SequenceEqual(result, answer));
        }
    }
}