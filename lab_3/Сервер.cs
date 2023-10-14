using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Сервер : Компютер, IConnectable
    {
        public Сервер(string iPАдреса, int потужність, string типОС)
            : base(iPАдреса, потужність, типОС)
        {
        }

        public void ПередатиДані(string адресаПриймача, string дані)
        {
            Console.WriteLine($"Сервер ({IPАдреса}) передав дані до {адресаПриймача}: {дані}");
        }

        public void Підключити(Компютер пристрій)
        {
            Console.WriteLine($"Сервер ({IPАдреса}) підключився до {пристрій.IPАдреса}");
        }

        public void Відключити(Компютер пристрій)
        {
            Console.WriteLine($"Сервер ({IPАдреса}) відключився від {пристрій.IPАдреса}");
        }
    }
}
