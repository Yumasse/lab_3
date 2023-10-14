using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Маршрутизатор : Компютер, IConnectable
    {
        public Маршрутизатор(string iPАдреса, int потужність, string типОС)
            : base(iPАдреса, потужність, типОС)
        {
        }

        public void ПередатиДані(string адресаПриймача, string дані)
        {
            Console.WriteLine($"Маршрутизатор ({IPАдреса}) передав дані до {адресаПриймача}: {дані}");
        }

        public void Підключити(Компютер пристрій)
        {
            Console.WriteLine($"Маршрутизатор ({IPАдреса}) підключився до {пристрій.IPАдреса}");
        }

        public void Відключити(Компютер пристрій)
        {
            Console.WriteLine($"Маршрутизатор ({IPАдреса}) відключився від {пристрій.IPАдреса}");
        }
    }

}
