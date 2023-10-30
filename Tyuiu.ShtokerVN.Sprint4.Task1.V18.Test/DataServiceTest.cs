using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint4.Task1.V18.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7 };

            int res = ds.Calculate(numsArray);
            int wait = 79;

            Assert.AreEqual(wait, res);
        }
    }
}
