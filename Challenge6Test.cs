using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges.Tests
{
    [TestClass()]
    public class Challenge6Test
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var result = Challenges.Challenge6.Solution(10, 85, 30);
            var answer = 3;
            Assert.IsTrue(result == answer);
        }
    }
}