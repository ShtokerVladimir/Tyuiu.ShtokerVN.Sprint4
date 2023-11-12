using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint4.Task4.V14.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Штокер В.Н. | ИИПб-23-1";

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                                             *");
            Console.WriteLine("* Задание #4                                                                               *");
            Console.WriteLine("* Вариант #14                                                                              *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич  | ИИПб-23-1                                        *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный                         *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8. Заменить нечетные элементы массива на 0.  *");
            Console.WriteLine("* 1, 3, 7, 7, 6,                                                                           *");
            Console.WriteLine("* 4, 2, 6, 3, 3,                                                                           *");
            Console.WriteLine("* 4, 5, 1, 4, 6,                                                                           *");
            Console.WriteLine("* 7, 5, 2, 7, 7,                                                                           *");
            Console.WriteLine("* 2, 4, 4, 4, 7,                                                                           *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Количество строчек в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Количество колонок в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Количество колонок и строчек в массиве: ");
            Console.WriteLine(rows + " | " + columns);
            int[,] mas2 = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i}, {j} элемент массива");
                    mas2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Массив : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Измененная матрица: ");
            int[,] mas1 = ds.Calculate(mas2);

            Console.WriteLine("\nМассив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{mas1[i, j]} \t");
                }
                Console.WriteLine();
               
            }
            Console.ReadKey();
        }
    }
}
