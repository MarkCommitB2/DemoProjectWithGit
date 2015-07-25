using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestWithGitProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var string1 = string.Empty;
            var string2 = "test";
            Assert.AreEqual(string1, string2);
        }
    }
}
