using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint4.Task1.V18.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task1.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                           *");
            Console.WriteLine("* Тема: Обработка структурных типов                                                                                   *");
            Console.WriteLine("* Задание #1                                                                                                          *");
            Console.WriteLine("* Вариант #18                                                                                                         *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                                    *");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                            *");
            Console.WriteLine("* подсчитать сумму нечетных элементов массива {7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7} введенных с клавиатуры *");
            Console.WriteLine("*                                                                                                                     *");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                    *");
            Console.WriteLine("***********************************************************************************************************************");

            int len;
            Console.Write("Введите кол-во элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len-1; i++)
            {
                Console.Write("Введите значение " + i + "элемент массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i =0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                                           *");
            Console.WriteLine("***********************************************************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
