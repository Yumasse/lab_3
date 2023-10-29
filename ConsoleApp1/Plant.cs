using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interface;

namespace Task_1
{
    public class Plant : LivingOrganism, IReproducible
    {
        public int PhotosynthesisEfficiency { get;  set; }

        public Plant(int energy, int age, int size, int photosynthesisEfficiency) : base(energy, age, size)
        {
            PhotosynthesisEfficiency = photosynthesisEfficiency;
        }


        public override void Live()
        {
            Energy -= 2;
            Energy += PhotosynthesisEfficiency;
        }

        public LivingOrganism Reproduce()
        {
            Energy -= 2;
            return new Plant(Energy / 2, 0, Size / 2, PhotosynthesisEfficiency);
        }
    }
}
