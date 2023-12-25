using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint1.Task6.V16.Lib;

namespace Tyuiu.MusaevRS.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string st = "Hello World!?";
            var result0 = ds.CheckSpecSymbols(st);
            var result1 = Convert.ToInt32(result0);
            Assert.AreEqual(1, result1);
        }
    }
}
