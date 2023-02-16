using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Shop
{
    internal interface ICrud
    {
        void Search();
        void Create();
        void Read();
        void Update();
        void Delete();
        
    }
}
