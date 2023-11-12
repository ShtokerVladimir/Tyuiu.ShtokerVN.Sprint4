using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint4.Task5.V1.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Штокер В.Н. | ИИПб-23-1";

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                                     *");
            Console.WriteLine("* Задание #5                                                                               *");
            Console.WriteLine("* Вариант #1                                                                               *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич  | ИИПб-23-1                                        *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный                         *");
            Console.WriteLine("* случайными значениями в диапазоне от -9 до 8. Заменить положительные элементы на 1       *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] sigma = new int[rows1, columns];

            Console.WriteLine("********************************************************************************************");

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sigma[i, j] = rnd.Next(-9, 8);
                }
            }

            Console.WriteLine("\n Массив : ");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{sigma[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            sigma = ds.Calculate(sigma);

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{sigma[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }    
    }
}
