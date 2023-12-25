using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint1.Task7.V21.Lib;

namespace Tyuiu.MusaevRS.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double res;
            DataService ds = new DataService();
            res = ds.Calculate(0, 1);
            Assert.AreEqual(1, res);

        }
    }
}
