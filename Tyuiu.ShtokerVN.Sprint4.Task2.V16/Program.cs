using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint4.Task2.V16.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                           *");
            Console.WriteLine("* Тема: Обработка структурных типов                                                                                   *");
            Console.WriteLine("* Задание #2                                                                                                          *");
            Console.WriteLine("* Вариант #16                                                                                                         *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                                    *");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                            *");
            Console.WriteLine("* подсчитать сумму нечетных элементов массива от 2 до 9                                                               *");
            Console.WriteLine("*                                                                                                                     *");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                    *");
            Console.WriteLine("***********************************************************************************************************************");

            int len;
            Console.Write("Введите кол-во элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2, 9);
            }

            Console.WriteLine("Массив:");
            for (int i =0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }


            Console.WriteLine();
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                                           *");
            Console.WriteLine("***********************************************************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Сумма нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
