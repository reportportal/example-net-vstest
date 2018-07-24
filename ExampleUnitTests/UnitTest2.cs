using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ReportPortal.Shared;
using System;
using System.Collections;

namespace ExampleUnitTests
{
    public class UnitTest2
    {
        [Test]
        public void NUnitTestMethod1()
        {
            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Info, "Message from logger");
            Console.WriteLine("Console output from UnitTest2 - TestMetod1");
        }

        [Test, TestCaseSource(typeof(UnitTest2), "TestCases")]
        public void NUnitTestMethod2(int p)
        {
            Console.WriteLine("Income parameter is " + p);
            System.Threading.Thread.Sleep(100);
        }

        public static IEnumerable TestCases
        {
            get
            {
                for (int i = 0; i < 1000; i++)
                {
                    yield return new TestCaseData(i);
                }
            }
        }
    }
}
