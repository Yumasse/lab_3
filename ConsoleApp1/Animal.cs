using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interface;

namespace Task_1

{
    public class Animal : LivingOrganism, IPredator, IReproducible
    {

        private int Strength { get; set; }

        public Animal(int energy, int age, int size, int strength) : base(energy, age, size)
        {
            Strength = strength;
        }


        public override void Live()
        {
            Energy -= 5;
        }

        public void Hunt(LivingOrganism prey)
        {
            if (Strength > prey.Size)
            {
                Energy += 10;
                prey.Energy -= 10;
            }
        }

        public LivingOrganism Reproduce()
        {
            return new Animal(Energy / 2, 0, Size / 2,Strength );
        }
    }
}
