using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace work_with_txt_file
{
    class Program
    {
        static bool IsUnic (string tempCh, char a)
        {
            for (int i = 0; i < tempCh.Length; i++)
            {
                if (tempCh[0]==a)
                {
                    return false;
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            //Чтение из файла
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\Новый текстовый документ.txt");
            System.Console.WriteLine("{0}", text);
            Console.WriteLine("\nКолличество символов = {0}", text.Length);
            
            //Подсчет количества слов
            string[] textMass = text.Split(' ');
            Console.WriteLine("Количество слов:" + textMass.Length);
            
            //Процентное соотношение символов
            Console.WriteLine("Введите букву");
            string s = Console.ReadLine();
            char[] array = text.ToCharArray();
            int temp = 0;
            foreach (char sumbol in array)
            {
                if(sumbol == s[0])
                temp++;
            }
            int copy = text.Length;
            double procentOfSumbol = (double)temp /copy;
            Console.WriteLine("Колличество симоволов 'a' = {0}%", procentOfSumbol);
            
            //Перевод текста в нижний регистр и посчитать самый часто встречающийся символ
            text = text.ToLower();
            string tempSt = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (IsUnic(tempSt, text[i])==true)
                {
                    tempSt = tempSt + text[i];
                }

            }
        }
    }
}
