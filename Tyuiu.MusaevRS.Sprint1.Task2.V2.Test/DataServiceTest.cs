using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint1.Task2.V2.Lib;

namespace Tyuiu.MusaevRS.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 2;
            var res = ds.ConvertHourToMin(value);
            Assert.AreEqual(120, res);
        }
    }
}
