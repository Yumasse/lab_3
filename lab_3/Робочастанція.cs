using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class РобочаСтанція : Компютер, IConnectable
    {
        public РобочаСтанція(string iPАдреса, int потужність, string типОС)
            : base(iPАдреса, потужність, типОС)
        {
        }

        public void ПередатиДані(string адресаПриймача, string дані)
        {
            Console.WriteLine($"Робоча станція ({IPАдреса}) передав дані до {адресаПриймача}: {дані}");
        }

        public void Підключити(Компютер пристрій)
        {
            Console.WriteLine($"Робоча станція ({IPАдреса}) підключилася до {пристрій.IPАдреса}");
        }

        public void Відключити(Компютер пристрій)
        {
            Console.WriteLine($"Робоча станція ({IPАдреса}) відключилася від {пристрій.IPАдреса}");
        }
    }
}
