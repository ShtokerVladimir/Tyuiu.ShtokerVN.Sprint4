using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint4.Task0.V18.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int res = ds.GetSumOddArrEl(numsArray);
            int wait = 41;

            Assert.AreEqual(wait, res);
        }
    }
}
