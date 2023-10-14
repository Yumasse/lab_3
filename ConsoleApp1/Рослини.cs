using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Рослина : ЖивийОрганізм
    {
        public int Ріст { get; set; }

        public Рослина(int енергія, int вік, int розмір, int ріст):
            base(енергія, вік, розмір)
        {
            Ріст = ріст;
        }
    }
}
