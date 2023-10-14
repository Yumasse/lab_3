using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Тварина : ЖивийОрганізм, IPredator
    {
        public int Швидкість { get; set; }
        public bool МожливістьПолювання { get; set; }

        public Тварина(int енергія, int вік, int розмір, int швидкість, bool можливістьПолювання)
            : base(енергія, вік, розмір)
        {
            Швидкість = швидкість;
            МожливістьПолювання = можливістьПолювання;
        }

        public bool Полювати(ЖивийОрганізм жертва)
        {
            if (МожливістьПолювання && Енергія >= жертва.Розмір && Швидкість >= (жертва as Тварина)?.Швидкість)
            {
                Енергія += жертва.Енергія;
                return true;
            }
            return false;
        }
    }
}
