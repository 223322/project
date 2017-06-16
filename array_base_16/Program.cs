using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_base_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести массив, состоящий из 12 элементов действительного типа. Определить количество чисел, стоящих между максимальным и минимальным элементами
            
            int temp=0;
            Random ran = new Random();
            int firstNum;
            int secondNum;
            Console.WriteLine("первое число: {0}", firstNum = ran.Next(0, 300));
            Console.WriteLine("второе число {0}", secondNum = ran.Next(0, 300));
            if (firstNum > secondNum)
            {
                int copy = firstNum;
                firstNum = secondNum;
                secondNum = copy;
            }
            int[] array = new int[14];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ran.Next(0, 300);
                Console.WriteLine(array[i]);
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>firstNum)
                {
                    if (array[i]<secondNum)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("\nКоличество чисел, стоящих между максимальным и минимальным элементами: {0}", count);
        }
    }
}
