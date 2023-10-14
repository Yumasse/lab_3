using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ЖивийОрганізм
    {
        public int Енергія { get; set; }
        public int Вік { get; set; }
        public int Розмір { get; set; }

        public ЖивийОрганізм(int енергія, int вік, int розмір)
        {
            Енергія = енергія;
            Вік = вік;
            Розмір = розмір;
        }

    }
    public interface IReproducible
    {
        void Розмножитися();
    }
    public interface IPredator
    {
        bool Полювати(ЖивийОрганізм жертва);
    }

}
