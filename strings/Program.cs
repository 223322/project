using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Максимальное и минимальное слово.
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\Новый текстовый документ (2).txt");
            string[] textMass = text.Split(new char[] {' ', ',', '.', '—', '«', '»', '-', '"'});
            int wordLength = textMass[0].Length;
            string maxWord="";
            string minWord = "";
            int temp = 0;
            foreach (string a in textMass)
            {
                int tempNew = a.Length;
                if (tempNew > wordLength)
                {
                    wordLength = tempNew;
                    maxWord = a;
                }
            }
            foreach (string a in textMass)
            {
                if (a.Length==maxWord.Length)
                {
                    Console.WriteLine("Кличество максимальных слов - {0}, длиной {1}", a, a.Length);
                    temp++;
                }
            }
            Console.WriteLine("Количество максимальных слов = {0}", temp);
            wordLength = textMass[0].Length;
            temp = 0;
            foreach (string a in textMass)
            {
                int tempNew = a.Length;
                if ((tempNew <= wordLength)&&(tempNew !=0))
                {
                    wordLength = tempNew;
                    minWord = a;
                }
            }
            foreach (string a in textMass)
            {
                if (a.Length == minWord.Length)
                {
                    Console.WriteLine("Кличество минимальных слов - {0}, длиной {1}", a, a.Length);
                    temp++;
                }
            }
            Console.WriteLine("Количество минимльных слов = {0}", temp);
            Console.WriteLine("Количество слов:" + textMass.Length);
            
            //Кодирование.
            char x = 'a';
            int intx = (int)x;
            Console.WriteLine(intx);

            intx = intx + 5;
            Console.WriteLine(intx);

            Console.WriteLine((char)intx);
            /////////////////////////////////////////////////////// 

            char[] textMassCh = text.ToCharArray();
            string newText = "";
            foreach (char a in textMassCh)
            {
                int copy = (int)a;
                copy = copy + 5;
                newText = newText + (char)copy;
            }
            Console.WriteLine(newText);
            string oldText = ""; 
            foreach (char a in newText)
            {
                int copy = (int)a;
                copy = copy - 5;
                oldText = oldText +(char)copy;
            }
            Console.WriteLine(oldText);
        }
    }
}
