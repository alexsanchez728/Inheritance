using System;

namespace inheritance.Pieces.Legs
{
    class Shorts : Legbase, IMoveable
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public int HowFarIMoved { get; private set; }
        // anybody should be able to read it, but only I can set it

        // this is from the base class
        public override void Jump(int howHigh)
        {
            Console.WriteLine($"shorts jumped {howHigh} feet in the air");
        }

        // Walk is not implimented here but is in LegBase class, so there is no compile error


        // this is from the interface
        public void Run(int howFar)
        {
            HowFarIMoved += howFar;
            Console.WriteLine($"shorts ran {howFar} miles");
        }

        public override void Walk(int numberOfSteps)
        {
            HowFarIMoved += numberOfSteps;
            base.Walk(numberOfSteps);
        }
    }
}
