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
        static void Main(string[] args)
        {
            //Чтение из файла
            string text = System.IO.File.ReadAllText(@"C:\Users\USER\Desktop\Новый текстовый документ.txt");
            System.Console.WriteLine("{0}", text);
            Console.WriteLine("\nКолличество символов = {0}", text.Length);
            //Подсчет количества слов
            string s = "";
            string[] textMass;
            StreamReader sr = new StreamReader(@"C:\Users\USER\Desktop\Новый текстовый документ.txt");
            while (sr.EndOfStream != true)
            {
                s = sr.ReadLine();
            }
            textMass = s.Split(' ');
            Console.WriteLine("Количество слов: = {0}", textMass.Length);
            //Процентное соотношение символов
            
            
            
        }
    }
}
