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
            Assert.AreEqual(string1, string2, 
                string.Format("expected {0} and {1} to be the same", string1, string2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var isBoolTest = true;
            Assert.IsFalse(isBoolTest,  "Expected False, but failed.");
        }
    }
}
