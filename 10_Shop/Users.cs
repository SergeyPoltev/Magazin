using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _10_Shop
{
    public class Users
    {
        public int id;
        public string login;
        public string passwordd;
        public string role;
        public static string json;
        public static string text;
        public Users(int ids, string l, string p, string r)
        {
            id = ids;
            login = l;
            passwordd = p;
            role = r;

        }
    }
}
