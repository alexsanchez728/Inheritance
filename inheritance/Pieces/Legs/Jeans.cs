using System;

namespace inheritance.Pieces.Legs
{
    class Jeans : Legbase, IMoveable
    {
        public int HowFarIMoved { get; set; }
        // auto property

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Too cool to jump.");
        }

        public void Run(int howFar)
        {
            HowFarIMoved += howFar;
            Console.WriteLine($"skirt ran {howFar} feet before crapping up and falling over from lack of exercise.");
        }

        public override void Walk(int numberOfSteps)
        {
            HowFarIMoved += numberOfSteps;
            base.Walk(numberOfSteps);
        }
    }
}
