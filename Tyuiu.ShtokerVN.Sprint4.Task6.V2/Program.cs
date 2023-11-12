using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint4.Task6.V2.Lib;

namespace Tyuiu.ShtokerVN.Sprint4.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Штокер В.Н. | ИИПб-23-1";

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                           *");
            Console.WriteLine("* Тема: Обработка структурных типов                                                                   *");
            Console.WriteLine("* Задание #6                                                                                          *");
            Console.WriteLine("* Вариант #2                                                                                          *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич  | ИИПб-23-1                                                   *");
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                            *");
            Console.WriteLine("* Дан строковый массив данных [Белый, Черный, Зеленый, Синий, Красный, Желтый, Фиолетовый], используя *");
            Console.WriteLine("* класс Array, выведите элементы массива, длина которых больше 5 символов                             *");
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                    *");
            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("Белый, Черный, Зеленый, Синий, Красный, Желтый, Фиолетовый                                            *");

            string[] array = ds.Calculate(new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" });

            Console.WriteLine("*******************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                          *");
            Console.WriteLine("*******************************************************************************************************");

            foreach (string item in array)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
