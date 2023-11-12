using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint4.Task6.V2.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            CollectionAssert.AreEqual(new string[] { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" }, ds.Calculate(new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "фиолетовый" }));
        }
    }
}
