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
        static bool IsUnic (string tempSt, char a)
        {
            for (int i = 0; i < tempSt.Length; i++)
            {
                if (tempSt[i]==a)
                {
                    return false;
                }
            }
            return true;
        }
        static int NumOfSymbolInText(char symbol, string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i]==symbol)
                {
                    count++;
                }
            }
            return count;
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
            Console.WriteLine("Колличество симоволов '{0}' = {1}%", s, procentOfSumbol);
            
            //Перевод текста в нижний регистр и посчитать самый часто встречающийся символ
            text = text.ToLower();
            string tempSt = "";
            for (int i = 0; i < text.Length; i++)
            {
                char tempCh = text[i];
                if (IsUnic(tempSt, text[i]))
                {
                    tempSt = tempSt + text[i];
                }
                
            }

            for (int i = 0; i < tempSt.Length; i++)
            {
                int tempInt = NumOfSymbolInText(tempSt[i], tempSt);
                string num = i + ";" + "/r/n";
                System.IO.File.AppendAllText(@"C:\Users\student\Desktop\Новый текстовый документ.txt", num);
               //foreach (char sumbol in tempSt)
               //{
               //    if (sumbol == tempSt[i])
               //        temp++;
               //}
               //copy = tempSt.Length;
               //double procentOfSymbol = (double)temp / copy;
                //Console.WriteLine("Количество симвлов {0} = {1}%", tempSt[i], procentOfSymbol);
            }
            string readText = lowerText;
            Console.WriteLine(readText);
        }
    }
}
