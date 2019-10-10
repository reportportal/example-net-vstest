using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReportPortal.Shared;
using System;
using System.Threading.Tasks;

namespace ExampleUnitTests.MsTests
{
    [TestClass]
    public class MsTestClass2
    {
        [TestMethod]
        [Description("This is description of TestMethod1")]
        [TestCategory("Category1"), TestCategory("Category2")]
        public void TestMethod1()
        {
            Log.Info("Message from logger");
            Log.Debug("Debug Message from logger");
            Log.Error("Error Message from logger");
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
            Log.Info("Wow this is cat! {rp#file#cat.png}");

            TestContext.WriteLine("this is trace message via TestContext.WriteLine");
            TestContext.WriteLine("this is 2nd trace message via TestContext.WriteLine");

            TestContext.AddResultFile("cat.png");
        }

        [TestMethod]
        public async Task FailedMethod4()
        {
            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Console output");
                Log.Debug("Logger output");
            }

            Assert.IsTrue(false);
        }

        [DataTestMethod]
        [DataRow("sample.1")]
        [DataRow("sample.2")]
        public void Test5(string input)
        {
            Log.Info(input);
        }
    }
}
