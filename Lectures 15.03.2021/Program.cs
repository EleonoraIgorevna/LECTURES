using System;



namespace Lectures_15._03._2021
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int value1 = 1;
            {

                int value2 = 2;
                Console.WriteLine($"{value1}{value2}");

            }
            {

                int value2 = 20;
                Console.WriteLine($"{value1}{value2}");

            }

            Console.WriteLine($"{value1}");

            // Console.WriteLine($"{value2}"); - Имя не существует в текущем контексте.

            //Си шарп поддерживает представление чисел в десятичной, шестнадцатеричной, и двоичной форме 

            //диапозон

            //Console.WriteLine($"{int.MaxValue}");
            //Console.WriteLine(int.MinValue);

            bool isWinterComing = true; //флаг поднят


            //a+=1; = a=a+1;



            int knowledges = 0b01111; //знания студента, четыре включенных бита

            //Маски профессий
            int backenderMask = 0b010111;
            int frontenderMask = 0b011011;
            int designerMask = 0b110000;


            //Те навыки из каждой профефессии, которые присутствуют у студента.

            int backenderKnowledges = knowledges & backenderMask;
            int frontenderKnowledges = knowledges & frontenderMask;
            int designerKnowledges = knowledges & designerMask;

            //Если навыки полностью совпали, мы пишем true, иначе False
            Console.WriteLine(backenderKnowledges==backenderMask);
            Console.WriteLine(frontenderKnowledges == frontenderMask);
            Console.WriteLine(designerKnowledges == designerMask);
            

            //Оператор If else

            string username = Console.ReadLine();
            if (username=="admin") 
            {
                Console.WriteLine("Администратор");
            }
            else
            {
                Console.WriteLine("Пользователь");
            }

            string username = Console.ReadLine();
            bool isAdmin = username == "admin";
            if (isAdmin)
            {
                Console.WriteLine("Администратор");
            }
            else
            {
                Console.WriteLine("Пользователь");
            }
           
            */
            string username = Console.ReadLine();
            bool isAdmin = username == "admin";
            if (!isAdmin)
            {
         
                Console.WriteLine("Доступ только для Администратора.");
            }
            
                Console.WriteLine("Это сообщение увидят все");



            // if else можно комбинировать несколько раз = switch-case


            //ЛЕКЦИИ 2
            // Область видимости
            int Valueone = 42;
            {
                int Valuetwo = 5;
                Console.WriteLine($"{Valueone} {Valuetwo}");
            }
            {
                int Valuetwo = 3;
                Console.WriteLine($"{Valueone} {Valuetwo}");
            }
            Console.WriteLine($"{Valueone}");



            // Числовые типы данных
            //byte from 0 to 255
            //int from - 2147483648 to 2147483647
            //long from -92233720368547758080 to 9223372036854775807
            //int decimalLiteral = 42 - просто число в десятичной форме;
            //int hexLiteral = 0x2A - 0x указывает на шестнадцатеричную форму;
            //int binaryLiteral = ob_0010_1010 - ob указывает на двоичную форму;
            //0b указывает на двоичную  форму. Знаки_ можно использовать для разделения разрядов. Их использование никак не влияет на значение переменной.



            // Представление чисел в разных системах счисления. _ никак не влияет на значение переменной.
            /* int million = 1_000_000;
             int oneMillion = 1000000;
             Console.WriteLine(million);
             Console.WriteLine(oneMillion);



             // Числовые типы данных с плавающей запятой. Более точное число занимает больше Операционной памяти.
             /*
               float точность  6-9 цифр
               double точность 15-17 цифр
               decimal точность 28-29 цифр
             */



            // Диапозон значений и как его найти
            /* Console.WriteLine($"Тип int, минимальное значение {int.MinValue} ");
             Console.WriteLine($"Тип int, минимальное значение {int.MaxValue} ");
             Console.WriteLine($"Тип byte, минимальное значение {byte.MinValue} ");
             Console.WriteLine($"Тип byte, минимальное значение {byte.MaxValue} ");
             Console.WriteLine($"Тип long, минимальное значение {long.MinValue} ");
             Console.WriteLine($"Тип long, минимальное значение {long.MaxValue} ");
             */



            //Представление даты и времени в С#

            /* DateTime dateAndTime = new DateTime(2021, 1, 1, 16, 23, 42);
             DateTime date = new DateTime(2021, 1, 1);
             Console.WriteLine(dateAndTime); // 01.01.2021 16:23:42
             Console.WriteLine(date);//01.01.2021 00:00:00
            */

           // DateTime jan01 = new DataTime(2020, 1, 1);









        }
        
    }
}
