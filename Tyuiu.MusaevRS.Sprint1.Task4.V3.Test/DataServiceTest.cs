using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint1.Task4.V3.Lib;

namespace Tyuiu.MusaevRS.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            double x, y;
            x = 27;
            y = 24;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);

        }
    }
}
