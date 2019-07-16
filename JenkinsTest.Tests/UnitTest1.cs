using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsTest;

namespace JenkinsTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            JenkinsTest.Controllers.APICustom abc = new Controllers.APICustom();
            Assert.AreEqual("jay", abc.CreateName());
        }
    }
}
