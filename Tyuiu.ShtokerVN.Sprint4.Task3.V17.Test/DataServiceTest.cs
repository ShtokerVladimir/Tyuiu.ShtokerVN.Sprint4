using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint4.Task3.V17.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 6, 4, 2, 2, 1 },
                                          { 3, 6, 5, 4, 1 },
                                          { 5, 2, 3, 1, 6 },
                                          { 8, 8, 4, 5, 3 },
                                          { 7, 4, 5, 1, 6} };

            int res = ds.Calculate(mas2);
            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}
