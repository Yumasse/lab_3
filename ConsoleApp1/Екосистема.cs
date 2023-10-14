using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Екосистема
    {
        private List<ЖивийОрганізм> організми = new List<ЖивийОрганізм>();

        public void ДодатиОрганізм(ЖивийОрганізм організм)
        {
            організми.Add(організм);
        }

        public void ВзаємодіяОрганізмів()
        {
            foreach (var організм1 in організми)
            {
                foreach (var організм2 in організми)
                {
                    if (організм1 != організм2)
                    {
                        if (організм1 is IPredator && організм2 is ЖивийОрганізм)
                        {
                            (організм1 as IPredator).Полювати(організм2);
                        }
                        else if (організм1 is IReproducible && організм2 is IReproducible)
                        {
                            (організм1 as IReproducible).Розмножитися();
                            (організм2 as IReproducible).Розмножитися();
                        }
                    }
                }
            }
        }
    }
}
