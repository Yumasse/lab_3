using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class СимуляціяРуху
    {
        public void СимулюватиРух(Дорога дорога, List<ТранспортнийЗасіб> транспортніЗасоби)
        {
            Console.WriteLine($"Дорога довжиною {дорога.Довжина} метрів і {дорога.КількістьСмуг} смугами");

            foreach (var транспорт in транспортніЗасоби)
            {
                Console.WriteLine($"На дорозі рухається {транспорт.Тип}");
                транспорт.Рухатися();
            }

        }
    }
}
