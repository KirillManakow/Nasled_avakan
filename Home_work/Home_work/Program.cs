using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
   internal class Program
    {
        public class Book
        {
            public string writer { get; set; }
            public string Name { get; set; }
        }


        static void Main(string[] args)
        {

            List<string> author = new List<string>() { };
            List<Book> books = new List<Book>();
            int g;
            int a;
            string h;
            string l;
            string k;

            Console.WriteLine("Введите цифру необходимого действия:\n1.Добавить автора/Удалить автора\n2.Добавить произведение/Удалить произведение\n3.Поиск произведений автора");
            a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Добавить автора");
                Console.WriteLine("Введите ФИО автора");
                string writer = Console.ReadLine();
                Console.WriteLine("");
                author.Add(writer);
                author.Add("Хадзиме Исаяма");
                author.Add("Джордж Оруэлл");
                author.Add("Хирохико Араки");
                foreach (string s in author)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("Удалить автора?\n1.Да\n2.Нет");
                g = int.Parse(Console.ReadLine());
                if (g == 1)
                {
                    Console.WriteLine("Введите ФИО автора");
                    string writer1 = Console.ReadLine();
                    Console.WriteLine("Удалить автора - " + writer1);
                    author.Remove(writer1);
                    foreach (string s in author)
                    {
                        Console.WriteLine(s);
                    }
                }
                Console.ReadKey();
            }
            else if (a == 2)
            {
                Console.WriteLine("Введите Автора и Название книги через Enter");
                l = Console.ReadLine();
                k = Console.ReadLine();
                books.Add(new Book() { writer = l, Name = k });
                books.Add(new Book() { writer = "Джордж Оруэлл", Name = "Дочь священника" });
                books.Add(new Book() { writer = "Джордж Оруэлл", Name = "1984" });
                Console.ReadKey();
            }
            else if (a == 3)
            {// заполняем книги

                Console.WriteLine("Введите Автора или название книги");
                h = Console.ReadLine();
                books.Add(new Book() { writer = "Джордж Оруэлл", Name = "1984" });
                books.Add(new Book() { writer = "Хирохико Араки", Name = "ジョジョの奇妙な冒険 (Jojo nokimy ōnabōken)" });
                books.Add(new Book() { writer = "Хадзиме Исаяма", Name = "タイタンの攻撃(Tai Tan no kōgeki)" });
                // ищем 1 элемент
                Book found = books.Find(item => item.writer == h || item.Name == h);

                // выводим элемент на экран
                Console.WriteLine("Автор:{0}, Название:{1}", found.writer, found.Name);

                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}