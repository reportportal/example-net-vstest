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
            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Debug, "Debug Message from logger");
            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Error, "Error Message from logger");
            Console.WriteLine("Console1 output from UnitTest2 - TestMetod1");
            Console.WriteLine("Console2 output from UnitTest2 - TestMetod1");
            Console.WriteLine("Console3 output from UnitTest2 - TestMetod1");
            Console.WriteLine("Console4 output from UnitTest2 - TestMetod1");
            Console.WriteLine("Console5 output from UnitTest2 - TestMetod1");
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
            TestContext.WriteLine("this is trace message via TestContext.WriteLine");
            TestContext.WriteLine("this is 2nd trace message via TestContext.WriteLine");
            // TODO: AddResultFile is not available in netcoreapp target framework
            //TestContext.AddResultFile("cat.png");
        }
    }
}
