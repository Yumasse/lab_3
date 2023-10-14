using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            var екосистема = new Екосистема();
            var кролик = new Тварина(50, 1, 10, 5, true);
            var ведмідь = new Тварина(100, 3, 20, 2, true);
            var трава = new Рослина(10, 1, 5, 2);
            var бактерія = new Мікроорганізм(5, 0, 1, true);

            екосистема.ДодатиОрганізм(кролик);
            екосистема.ДодатиОрганізм(ведмідь);
            екосистема.ДодатиОрганізм(трава);
            екосистема.ДодатиОрганізм(бактерія);

            екосистема.ВзаємодіяОрганізмів();
        }
    }
}
