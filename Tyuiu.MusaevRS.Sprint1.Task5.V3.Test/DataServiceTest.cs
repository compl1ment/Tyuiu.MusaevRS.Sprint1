using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint1.Task5.V3.Lib;

namespace Tyuiu.MusaevRS.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int k = 1234567;
            DataService ds = new DataService();
            var result = ds.Calculate(k);
            Assert.AreEqual(5, result);
        }
    }
}
