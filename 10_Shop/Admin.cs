using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _10_Shop
{
    internal class Admin : ICrud
    {
        public static string path = "C:\\Users\\Сергей\\Desktop\\Data.json";
        public static List<Users> user;
        public static string logs, pssword, rles;
        public static int ides;
        public static List<Users> res;
        public void Search()
        {
            
        }
        public  void Create()
        {
            Console.Clear();
            Console.SetCursorPosition(13, 0);
            Console.WriteLine("Добро пожаловать, ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            for (int i = 2; i < 13; i++)
            {
                Console.SetCursorPosition(90, i);
                Console.WriteLine("|");
            }
            Console.SetCursorPosition(80, 0);
            Console.WriteLine("Роль: ");
            Console.SetCursorPosition(92, 2);
            Console.WriteLine("Администратор");
            Console.SetCursorPosition(92, 3);
            Console.WriteLine("Кассир");
            Console.SetCursorPosition(92, 4);
            Console.WriteLine("Кадровик");
            Console.SetCursorPosition(92, 5);
            Console.WriteLine("Склад-менеджер");
            Console.SetCursorPosition(92, 6);
            Console.WriteLine("Бухгалтер");
            Console.SetCursorPosition(92, 8);
            Console.WriteLine("Сохранить изменения");
            Console.SetCursorPosition(92, 9);
            Console.WriteLine("Escape - вернуться в меню");


            Console.SetCursorPosition(92, 2);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("ID: ");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Логин: ");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Пароль: ");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Роль: ");
            Console.SetCursorPosition(6, 2);
            ides = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(9, 3);
            logs = Console.ReadLine();
            Console.SetCursorPosition(10, 4);
            pssword = Console.ReadLine();
            Console.SetCursorPosition(8, 5);
            rles = Console.ReadLine();
            Users userq = new Users(ides, logs, pssword, rles);
            user.Add(userq);
            Users.json = JsonConvert.SerializeObject(user);
            File.AppendAllText(path,Users.json);
        }
        public void Read()
        {
            Console.Clear();
            int a = 3;
            Console.SetCursorPosition(13, 0);
            Console.WriteLine("Добро пожаловать, ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            for (int i = 2; i < 13; i++)
            {
                Console.SetCursorPosition(90, i);
                Console.WriteLine("|");
            }
            Console.SetCursorPosition(80, 0);
            Console.WriteLine("Роль: ");
            Console.SetCursorPosition(92, 2);
            Console.WriteLine("F1 - Добавить запись");
            Console.SetCursorPosition(92, 3);
            Console.WriteLine("F2 - Создать запись");
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("ID");
            Console.SetCursorPosition(30, 2);
            Console.WriteLine("Логин");
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("Пароль");
            Console.SetCursorPosition(70, 2);
            Console.WriteLine("Роль");
            Users.text = File.ReadAllText(path);
            List<Users> res = JsonConvert.DeserializeObject<List<Users>>(Users.text);
            if (res[0] != null)
            {
                foreach (var item in res)
                {
                    Console.SetCursorPosition(10, a);
                    Console.WriteLine(item.id);
                    Console.SetCursorPosition(30, a);
                    Console.WriteLine(item.login);
                    Console.SetCursorPosition(50, a);
                    Console.WriteLine(item.passwordd);
                    Console.SetCursorPosition(65, a);
                    Console.WriteLine(item.role);
                    a++;
                }
            }
            
        }
        public  void Update()
        {
            
        }
        public void Delete()
        {

        }
    }  
}
