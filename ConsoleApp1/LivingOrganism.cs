using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class LivingOrganism
    {
        public int Energy { get; internal set; }
        public int Age { get; internal set; }
        public int Size { get; internal set;}

        public LivingOrganism(int energy, int age, int size)
        {
            Energy = energy;
            Age = age;
            Size = size;
        }

        public abstract void Live();

    }

}
