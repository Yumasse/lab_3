using Task_1.Interface;

namespace Task_1
{
    public class Microorganism : LivingOrganism, IReproducible
    {

        private int MutationRate {  get; set; }


        public Microorganism(int energy, int age, int size, int mutationRate) : base(energy, age, size)
        {
            MutationRate = mutationRate;
        }


        public override void Live()
        {
            Energy -= 2;
            if (new Random().Next(100) < MutationRate)
                Size += 1;
        }

        public LivingOrganism Reproduce()
        {
            return new Microorganism (Energy / 2, 0, Size, MutationRate);
        }

    }
}

