using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShtokerVN.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 3)
                    {
                        count += array[i, j];
                    }
                }
            }
            return count;
        }
    }
}
