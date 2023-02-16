using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace _10_Shop
{
    class Program
    {
        public static int ideF = 1;
        public static string logF = "admin";
        public static string passF = "1234";
        public static string roleF = "Administrator";
        static void Main()
        {
            
            Users admFirst = new Users(ideF,logF,passF,roleF);
            List<Users> create = new List<Users>();
            Users.json = JsonConvert.SerializeObject(admFirst);
            File.AppendAllText(Admin.path, Users.json);
            Authoriz.All();


        }
    }


}