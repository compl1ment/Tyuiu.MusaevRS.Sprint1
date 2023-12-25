using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint1.Task3.V4.Lib;

namespace Tyuiu.MusaevRS.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void PurchaseAmountValid()
        {
            DataService ds = new DataService();
            double tetr, obl;
            int kol;

            tetr = 2.75;
            obl = 0.5;
            kol = 7;
            var res = ds.PurchaseAmount(tetr, obl, kol);


            Assert.AreEqual(22.75, res);




        }
    }
}
