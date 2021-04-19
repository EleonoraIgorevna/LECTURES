using System;

namespace Lectures_22._03._2021
{
    class Program
    {
        //static void Main(string[] args)

        //1



        //Функция это фрагмент програмного кода к которому можно обратиться из другого места программы. В функции выносятся операции, которые должны быть доступны 
        //из разных мест программы. Функция может содержать входные аргументы, с помощью которых мы можем изменять ее поведение, а также передавать ей необходимую информацию. 
        //Также функция может содержать результирующее значение.
        //функции в програмировании решают ряд задач. 
        //- позволяют разбить сложную программу на набо маленьких функций с которыми намного проще взаимодействовать (вносить правки и разбираться в их работе).
        //- позволяют переиспользовать код  и избежать излишнего дублирования кода. 

        //ФУНКЦИИ В ООП
        //В ООП функции описываются внутри классови называются методами.
        //Класс зачастую отражение какой-либо модели из реального мира. Класс Dog можжет содер;ать метод  Bark (лаять), а класс Calc 
        //может описывать методы Add/Subtract/Multiply/Divide
        //Ранее мы называли методы функциями, теперь будем назыывать методами. 

        //ОБЪЯВЛЕНИЕ МЕТОДОВ

        //Ранее мы обсуждали только метод Main ( точка входа в приложение) и методы класса Convert.

        //int i = Convert.ToInt32(Console.ReadLine());
        //здесь у класса Конверт вызывается метод Туинт32.  Метож принимает на вход строковый аргумент
        // (результат выполнения метода   Console.ReadLine) и отдает результат  в виде целого числа. Наряду с применением стандартных методов можно также использовать свои.

        /*static void Main(string[] args) //программа начинается с привычного нам метода МЭИН, в котором мы получаем имя пользователя путем вызова метода Гетюзернейм.
                                        //Далее мы передаем имя пользователя в метод Мейкгритикс, возвращающий персонализированное приветствие,которое мы  потом выводим на экран.
        {
            string name = GetUserName();
            string greetings = MakeGreeting(name);
            Console.WriteLine(greetings);
        }
        static string GetUserName()
        {
            Console.WriteLine("Привет, как тебя зовут?");//описание метода
            string userName = Console.ReadLine();
            return userName; //здесь оператор ретурн не заканчивает работу программы, а возвращает значение в вызывающий метод.
            //Важно, чтобы  тип возвращаемого значения совпадал с типом, указанном в объявлении метода. Сигнатура метода должна быть уникальной в пределах класса. Иначе произойдет ошибка сборки или ошибка во время выполнения программы.

        }
        static string MakeGreeting(string userName) //стринг - указание возвращаемого значения.Далее идеи Имя метода и затем перечисляем входные аргументы в круглых скобках.
            //Сигнатула метода должна быть уникальной в пределах класса.
        {

            return $"Привет,{userName}"; //описание метода.

        }*/

        //Мы можем возвращать, как значение переменной, так и результат выполнения выражения. Например метод ГетюзерНейм можно переписать так:
        /*static string GetUserName()
        {
            Console.WriteLine("Привет, как тебя зовут?");//описание метода
             return  = Console.ReadLine();
            

        }*/
        /* static void Main(string[] args)
         {
             string name = GetUserName();
             string greetings = MakeGreeting(name);
             Console.WriteLine(greetings);
         }
         static string GetUserName()
         {
             Console.WriteLine("Привет, как тебя зовут?");//описание метода
             return Console.ReadLine();

         }
         static string MakeGreeting(string userName)
         {

             return $"Привет,{userName}"; //описание метода.

         }*/

        // Бывают ситуации, когда из метода следует вернуть несколько значений. На практике в таких случаях используют классы, а также можно использовать возможность языка 
        //под названием named tuple (именованный кортеж).

        /* static void Main(string[] args)
         {
             (string lalalalala, int lilolilo) = AskUserInfo();
         }

         static (string name, int age) AskUserInfo()
         {
             Console.WriteLine("Как тебя зовут?");
             string name = Console.ReadLine();
             Console.WriteLine($"Приятно познакомиться, {name}! Сколько тебе лет?");
             int age = Convert.ToInt32(Console.ReadLine());
             return (name, age);
         }*/

        //Метод AskUserInfo возвращает кортеж знаний стринг и инт. Обратите внимание, что названия переменных и объявленных в теле метода или или в вызываемой функции,
        // не обязательно должны  совпадать с теми, что указаны в сигнатуре метода.


        //
        //ЗАЧЕМ РАЗДЕЛЯТЬ КОД НА МЕТОДЫ. ПРИНЦИП DRY
        //взглянем на программу, которая написана на одном методе.
        /*
        static void Main(string[] args)
        {
            (string name, int age)[] users;
            Console.WriteLine("Введите количество пользователей");
            int count = Convert.ToInt32(Console.ReadLine());
            users = new (string name, int age)[count];
            for (int i = 0; i < users.Length; i++)
            {
                Console.Write("Введите имя пользователя: ");
                string userName = Console.ReadLine();
                Console.Write("Введите возраст пользователя: ");
                int userAge = Convert.ToInt32(Console.ReadLine());
                users[i] = (userName, userAge);
                Console.WriteLine($"Пользователь {userName} ({userAge}) сохранен");

            }
            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.ReadKey();//?????
            Console.Clear();//?????

            int choice;
            do
            {
                Console.WriteLine("0 - Завершение работы");
                Console.WriteLine("1 - Просмотр всей базы данных");
                Console.WriteLine("2 - Просмотр пользователя");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Вывод базы данных:");
                    for (int i = 0; i < users.Length; i++)
                    {
                        Console.WriteLine($"{users[i].name} ({users[i].age})");
                    }
                }
                if (choice == 2)
                {

                    int userIndex;
                    do
                    {
                        Console.WriteLine($"Введите идентификатор пользователя - от 0 до {users.Length - 1}");
                        userIndex = Convert.ToInt32(Console.ReadLine());
                    } while (userIndex < 0 || userIndex >= users.Length);

                    Console.WriteLine($"{users[userIndex].name} ({users[userIndex].age})");
                }
            } while (choice != 0);*/

        //Попробуем структурировать через методы
        /*
        static void Main()
        {
            (string name, int age)[] users = CreateUsers();
            ShowMenu(users);
        }

        static (string name, int age)[] CreateUsers()
        {
            Console.WriteLine("Введите количество пользователей:");
            int count = ReadInt();
            (string name, int age)[] users = new (string name, int age)[count];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = CreateUser();
                Console.WriteLine($"Пользователь {FormatUserData(users[i])} сохранен");
            }

            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.ReadKey(); // что делает?
            Console.Clear();// что делает??

            return users;
        }

        static void ShowMenu((string name, int age)[] users)
        {
            int choice;
            do
            {
                choice = GetUserChoice();
                switch (choice)
                {
                    case 0: return;
                    case 1:
                        PrintUsers(users);
                        break;
                    case 2:
                        PrintSelectedUser(users);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }

        static (string userName, int userAge) CreateUser()
        {
            Console.Write("Введите имя пользователя: ");
            string userName = Console.ReadLine();
            Console.Write("Введите возраст пользователя: ");
            int userAge = ReadInt();
            return (userName, userAge);
        }
        static int GetUserChoice()
        {
            Console.WriteLine("0 - Завершение работы");
            Console.WriteLine("1 - Просмотр всей базы данных");
            Console.WriteLine("2 - Просмотр пользователя");
            return ReadInt();
        }

        static void PrintSelectedUser((string name, int age)[] users)
        {
            int userIndex;
            do
            {
                Console.WriteLine($"Введите идентификатор пользователя - от 0 до {users.Length - 1}");
                userIndex = ReadInt();
            } while (userIndex < 0 || userIndex >= users.Length);

            PrintUser(users[userIndex]);
        }

        static void PrintUsers((string name, int age)[] users)
        {
            Console.WriteLine("Вывод базы данных:");
            for (int i = 0; i < users.Length; i++)
            {
                PrintUser(users[i]);
            }
        }

        static void PrintUser((string name, int age) user)
        {
            Console.WriteLine(FormatUserData(user));
        }

        static string FormatUserData((string name, int age) user)
        {
            return $"{user.name} ({user.age})";
        }
        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        //методы позволяют дать подсказки другим разработчикам. Они выделяют небольшие куски кода в  небольшие функции - область и позволяют озаглавить ее.
        // При чтении структурированного кода нам не нужно читать от начала до концаю, как это делает компьютер. Люди больше ориентируются в информации, когда она 
        //структурирована и связана.
        // каждый метод - это определенный отрезок с логикой.

        //DON'T REPEAT YOURSELF - каждая еденица знания должна быть описана в коде один раз. Пример. Только один метод должен знать, как форматировать данные пользователя,
        //а все остальные части должны использовать этот мметод.
        //тернарный оператор

        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string role = GetUserRole(username);
            Console.WriteLine(role);
        }

        static string GetUserRole(string username)
        {
            if (username == "admin")
            { 
                return "Администратор";
            }
            else
            {
                return "Пользователь";           
            }
        

       

        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string role = GetUserRole(username);
            Console.WriteLine(role);
        }

        static string GetUserRole(string username)
        {
             return username == "admin" ? "Администратор" :  "Пользователь";
            
          
        }
        */


        // Визуализации работы стека и кучи.

        // Ключевое слово ref

        static void Main(string[] args)
        {
            int number = 1;

            int incremented = Increment(number);
            Console.WriteLine($"Исходное значение: {number}. Новое значение: {incremented}");

            int incrementedByRef = IncrementByRef(ref number);
            Console.WriteLine($"Исходное значение: {number}. Новое значение: {incrementedByRef}");
        }

        static int Increment(int value)
        {
            return ++value;
        }
        static int IncrementByRef(ref int value)
        {
            return ++value;
        }
 gd

















    }

}










































//Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
//Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

/*

static void Main(string[] args)
{

    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Какая у тебя фамилия?");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Какое имя.");
        string LastName = Console.ReadLine();
        Console.WriteLine("Напиши отчество.");
        string Patronymic = Console.ReadLine();
        string FullName = GetFullName(FirstName, LastName, Patronymic);
        Console.WriteLine(FullName);
    }
}
static string GetFullName(string FirstName, string LastName, string Patronymic)
{
    string UserName =  FirstName +" "+ LastName + " " + Patronymic ;
    return UserName; 
}*/

//2
/*
static void Main(string[] args)
{

    Console.WriteLine("Введи числа.");
    string value = Console.ReadLine();
    int SumOfValue = GetSum(value);
    Console.WriteLine(SumOfValue);
    Console.ReadLine();
}

static int GetSum(string value)
{

    string[] quantity = value.Split(' ');// пробел как разделитель
    int SumOfValue = 0;
    for (int i = 0; i < quantity.Length; i++)
    {
        string quantityvalue = quantity[i];
        int quantityvalue01 = int.TryParse(quantityvalue, out int num)

            ? num
            : 0;

        SumOfValue = SumOfValue + quantityvalue01;
    }

    return SumOfValue;*/




