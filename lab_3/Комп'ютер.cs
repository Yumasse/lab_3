using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Компютер
    {
        public string IPАдреса { get; set; }
        public int Потужність { get; set; }
        public string ТипОС { get; set; }

        public Компютер(string iPАдреса, int потужність, string типОС)
        {
            IPАдреса = iPАдреса;
            Потужність = потужність;
            ТипОС = типОС;
        }
    }
    public interface IConnectable
    {
        void ПередатиДані(string адресаПриймача, string дані);
        void Підключити(Компютер пристрій);
        void Відключити(Компютер пристрій);
    }

    // Клас "Мережа"
    public class Мережа
    {
        private List<Компютер> компютери = new List<Компютер>();

    public void ДодатиКомпютер(Компютер комп)
    {
        компютери.Add(комп);
    }

    public void ВзаємодіяКомпютерів()
    {
        foreach (var комп1 in компютери)
        {
            foreach (var комп2 in компютери)
            {
                if (комп1 != комп2)
                {
                    if (комп1 is IConnectable)
                    {
                        (комп1 as IConnectable).Підключити(комп2);
    (комп1 as IConnectable).ПередатиДані(комп2.IPАдреса, "Дані для передачі");
    (комп1 as IConnectable).Відключити(комп2);
}
                }
            }
        }
    }
}
}
