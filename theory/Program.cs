using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theory
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[5];
            //Console.WriteLine(array);
            //string[] seasons = new string[4] { "зима", "весна", "лето", "осень" };
            //Console.WriteLine(seasons);
            //int[,] numbers3 = new int[3, 2] { {6, 0}, {5, 7}, {8, 9} };

            //Есть матрица 7*4. Строки, которых семь, будут соответствовать дням недели, а 4 столбца - времени дня (00:00, 06:00, 12:00, 18:00). 
            //В качестве данных будет температура воздуха.
            //  Значение температуры с координатами 2,3 будет соответствовать температуре в среду в 18:00.На практике, конечно, такие данные представлялись 
            //бы в другом виде, но для примера подойдет.

            int[,] weather = new int[4, 4];
            weather[0, 0] = 6;
            weather[0, 1] = 5;
            weather[0, 2] = 2;
            weather[0, 3] = 9;
            weather[1, 0] = 6;
            weather[1, 1] = 6;
            weather[1, 2] = 6;
            weather[1, 3] = 6;
            weather[2, 0] = 6;
            weather[2, 1] = 6;
            weather[2, 2] = 6;
            weather[2, 3] = 6;
            weather[3, 0] = 6;
            weather[3, 1] = 6;
            weather[3, 2] = 6;
            weather[3, 3] = 6;
            Console.WriteLine(weather[4,4]);
        }
        }
}
