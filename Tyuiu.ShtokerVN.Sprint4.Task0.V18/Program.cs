using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint4.Task0.V18.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                   *");
            Console.WriteLine("* Тема: Обработка структурных типов                                           *");
            Console.WriteLine("* Задание #0                                                                  *");
            Console.WriteLine("* Вариант #18                                                                 *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* подсчитать сумму нечетных элементов массива: {9, 8, 7, 6, 5, 7, 3, 2, 7, 3} *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            Console.WriteLine("* Исходный массив:");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Сумма нечетных элементов массива = " + ds.GetSumOddArrEl(numsArray));
            Console.ReadKey();
        }
    }
}
