using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint4.Task4.V14.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 1, 3, 7, 7, 6 },
                                          { 4, 2, 6, 3, 3 },
                                          { 4, 5, 1, 4, 6 },
                                          { 7, 5, 2, 7, 7 },
                                          { 2, 4, 4, 4, 7} };

            int[,] wait = new int[5, 5] { { 0, 0, 0, 0, 6 },
                                          { 4, 2, 6, 0, 0 },
                                          { 4, 0, 0, 4, 6 },
                                          { 0, 0, 2, 0, 0 },
                                          { 2, 4, 4, 4, 0 } };

            int[,] res = ds.Calculate(mas2);
            CollectionAssert.AreEqual(wait, mas2);
        }
    }
}
