using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint4.Task5.V1.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] sigma = new int[5, 5] { { 1, 6, -5, -2, 8 }, { 7, -3, 6, -1, -6 }, { 2, -3, 5, -7, -1 }, { -6, 3, 5, 4, -9 }, { 6, -1, 4, -3, 3 } };

            int[,] res = ds.Calculate(sigma);
            int[,] wait = { { 1, 1, -5, -2, 1 }, { 1, -3, 1, -1, -6 }, { 1, -3, 1, -7, -1 }, { -6, 1, 1, 1, -9 }, { 1, -1, 1, -3, 1 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
