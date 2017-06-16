using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_avarege_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести два целочисленных массива − по 10 элементов в каждом.Сформировать новый массив, на четных местах которого будут элементы с
            //нечетными индексами из первого массива, а на нечетных – с четными
            //индексами из второго.

            Random ran = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = ran.Next(0, 1000);
                Console.WriteLine(array1[i]);
            }
           int[] array2 = new int[10];
           for (int i = 0; i < array2.Length; i++)
           {
               array2[i] = ran.Next(0, 1000);
               Console.WriteLine(array2[i]);
           }
           int[] array3 = new int[10];
           for (int i = 0; i < array3.Length; i++)
           {
               if (i%2==0)
               {
                   array3[i] = array1[i+1];
                   Console.WriteLine(array3[i]);
               }
               else
               {
                   array3[i] = array2[i-1];
                   Console.WriteLine(array3[i]);
               }
           }
        }
    }
}
