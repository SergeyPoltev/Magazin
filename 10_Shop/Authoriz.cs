using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _10_Shop
{
    public class Authoriz
    {
        public string login;
        public string password;
        public static Authoriz atributes = new Authoriz();

        public static void All()
        {
            Console.SetCursorPosition(45, 0);
            Console.WriteLine("Добро пожаловать в магазин ХОМЯЧКИ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Логин: ");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Пароль: ");
            Console.SetCursorPosition(9,2);
            int w = 9;
            string log = Console.ReadLine();
            string pass = "";
            List<char> password = new List<char>();
            while (true)
            {
                w++;
                Console.SetCursorPosition(w, 3);
                ConsoleKeyInfo symb = Console.ReadKey(true);
                if (symb.Key == ConsoleKey.Enter)
                    break;
                else
                {
                    Console.Write("*");
                    password.Add(symb.KeyChar);
                }
            }
            Console.WriteLine();
            string passStr = null;
            foreach (char c in password)
                passStr += c;
            if (Users.json.Contains("admin") && Users.json.Contains("1234"))
            {
                Admin read = new Admin();
                read.Read();
            }


            
            atributes.login = log;
            atributes.password = pass;
        }
    }
}
