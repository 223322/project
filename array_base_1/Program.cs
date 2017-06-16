using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_base_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести массив, состоящий из 14 элементов целого типа.Найти количест-во элементов четных по значению. 
            int[] array = new int[14];
            Random ran = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ran.Next(0, 1000);
                Console.WriteLine(array[i]);
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    count++;
            }
            Console.WriteLine("\nЧетных элементов в массиве: {0}", count);
        }
    }
}
