using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleMsTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Console output from UnitTest2 - TestMetod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Console output from UnitTest2 - TestMetod2");
        }
    }
}