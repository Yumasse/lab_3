using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ТранспортнийЗасіб : IDriveable
    {
        public string Тип { get; set; }
        public double Швидкість { get; set; }
        public double Розмір { get; set; }

        public ТранспортнийЗасіб(string тип, double швидкість, double розмір)
        {
            Тип = тип;
            Швидкість = швидкість;
            Розмір = розмір;
        }

        public void Рухатися()
        {
            Console.WriteLine($"{Тип} рухається зі швидкістю {Швидкість} км/год");
        }

        public void Зупинитися()
        {
            Console.WriteLine($"{Тип} зупинився");
        }
    }
}
