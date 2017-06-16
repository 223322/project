using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures5
{
    class Program
    {
        struct Book
        {
            public string name;
            public string manufacturer;
            public int year;
            public int quantity;
            public int price;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int s = Convert.ToInt32(Console.ReadLine());
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\Пользователь\Desktop\Программирование\Задачи\Cтруктуры, 5, база.txt");
            List<Book> listOfBook = new List<Book>();
            for (int i = 0; i < text.Count(); i++)
            {
                Book temp = new Book();
                temp.name = text[i].Split(';').ElementAt(0);
                temp.manufacturer = text[i].Split(';').ElementAt(1);
                temp.year = Convert.ToInt32(text[i].Split(';').ElementAt(2));
                temp.quantity = Convert.ToInt32(text[i].Split(';').ElementAt(3));
                temp.price = Convert.ToInt32(text[i].Split(';').ElementAt(4));
                listOfBook.Add(temp);
            }
            int sum = 0;
            for (int i = 0; i < listOfBook.Count; i++)
            {
                if (s == listOfBook[i].year)
                {
                    int temp = listOfBook[i].price;
                    sum += temp;
                    Console.WriteLine(listOfBook[i].name + " " + listOfBook[i].manufacturer + " " + listOfBook[i].year + " " + listOfBook[i].quantity + " " + listOfBook[i].price);
                }
                else
                {
                    Console.WriteLine("Нет данных");
                }
                Console.WriteLine("Сумма цен товаров, выпущенных в 2017 году: {0}", sum);
            }
        }
    }
}
