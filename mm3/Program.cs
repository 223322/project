using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm3
{
    class Program
    {
        static int method(int [][] masOfMas)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (masOfMas[i][j]>=0)
                    {
                        sum += masOfMas[i][j];
                        count++;
                    }
                }
            }
            int srZnach = sum / count;
            return srZnach;
        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Пользователь\Desktop\Программирование\Задачи\Массивы, 3.txt");
            string[] line = text.Split(';');
            int[][] masOfMas = new int[line.Length - 1][];
            string[] num = null;
            for (int i = 0; i < line.Length-1; i++)
            {
                num = line[i].Split(new char[] { ',' });
                for (int j = 0;  j < line.Length;  j++)
                {
                    masOfMas[i] = new int[6];
                    masOfMas[i][j] = Convert.ToInt32(num[j]);
                    Console.WriteLine("{0}\t", masOfMas[i][j]);
                }
            }
            Console.WriteLine(method(masOfMas));
        }
    }
}
