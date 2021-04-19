using System;

namespace Lectures_12._03._2021__1_
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("Hello World!");
            Console.WriteLine("Привет! Напиши свое имя");
            var name = Console.ReadLine();

           */
            //Console.WriteLine($"Привет, {name}"); //интерполяция

            // Console.WriteLine - выводит строку на экран и переводит консоль на новую строку.
            // Console.ReadKey - возвращает информацию о нажатой пользователем клавише. Перевод на новую строку не осуществляется.
            // Console.Read - возвращает информацию о нажатой пользователем клавише. Переводит консоль  на новую строку не осуществляется. Пользовательский вводит заверщается клавишей Энтер.
            // Console.Write - выводит строку на экран. Перевод на новую строку не осуществляется.
            // Console.Clear - очищает содержимое консоли.
            //Шаблонные строки ($) ставится перед шаблонными строками.Она же интерполяция.
            //+ это конкатенация
            //Console.WriteLine( "["+ DateTime.Now +"]" +"Hello, " +name + "!");
            // Console.WriteLine( $"[{ DateTime.Now}] Hello, { name }");

            Console.WriteLine("Привет! Напиши свое имя");
            var name = Console.ReadLine();

            Console.WriteLine("[" + DateTime.Now + "]" + "Hello, " + name + "!");
            Console.WriteLine($"[{DateTime.Now}] Hello, {name}!");





        }
    }
}
