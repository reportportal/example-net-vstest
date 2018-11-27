using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReportPortal.Shared;
using System;

namespace ExampleUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Info, "Message from logger");
            Console.WriteLine("Console output from UnitTest2 - TestMetod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Console output from UnitTest2 - TestMetod2");
        }

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod3()
        {
            // TODO: AddResultFile is not available in netcoreapp target framework
            //TestContext.AddResultFile("cat.png");
        }
    }
}
