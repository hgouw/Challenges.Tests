using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges.Tests
{
    [TestClass()]
    public class StringHelperTest
    {
        /// <summary>
        /// Unit testing for the null string which returns a true.
        /// </summary>
        [TestMethod()]
        public void IsNullOrEmptyTest1()
        {
            string str = null;
            Assert.IsTrue(str.IsNullOrEmpty());
        }

        /// <summary>
        /// Unit testing for the string "a" which returns a false.
        /// </summary>
        [TestMethod()]
        public void IsNullOrEmptyTest2()
        {
            string str = "a";
            Assert.IsFalse(str.IsNullOrEmpty());
        }

        /// <summary>
        /// Unit testing for the empty string which returns a true.
        /// </summary>
        [TestMethod()]
        public void IsNullOrEmptyTest3()
        {
            string str = "";
            Assert.IsTrue(str.IsNullOrEmpty());
        }

        /// <summary>
        /// Unit testing for the string "null" which returns a false.
        /// </summary>
        [TestMethod()]
        public void IsNullOrEmptyTest4()
        {
            string str = "null";
            Assert.IsFalse(str.IsNullOrEmpty());
        }
    }
}