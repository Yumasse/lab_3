﻿namespace Task_3
{
    class Program
    {
        static void Main()
        {
            var дорога = new Дорога(500, 4, 2);
            var автомобіль1 = new ТранспортнийЗасіб("Автомобіль", 60, 4);
            var автомобіль2 = new ТранспортнийЗасіб("Автомобіль", 70, 3);
            var вантажівка = new ТранспортнийЗасіб("Вантажівка", 40, 8);

            var транспортніЗасоби = new List<ТранспортнийЗасіб> { автомобіль1, автомобіль2, вантажівка };

            var симуляція = new СимуляціяРуху();
            симуляція.СимулюватиРух(дорога, транспортніЗасоби);
        }
    }
}