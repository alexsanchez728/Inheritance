using System;

namespace inheritance.Pieces.Legs
{
    class Skirt : Legbase, IMoveable
    {



        public string Material { get; set; }
        public Length Length { get; set; }
        int _howFarIMoved;

        public int HowFarIMoved { get => _howFarIMoved; }
        // read only function property

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Skirt jumped {howHigh} inches in the air");
        }

        public void Run(int howFar)
        {
            _howFarIMoved += howFar;
            Console.WriteLine($"skirt ran {howFar} uphill, bothways");

        }

        public override void Walk(int numberOfSteps)
        {
            _howFarIMoved += numberOfSteps;
            if (Length == Length.StreetCorner)
            {
                Console.WriteLine($"The {Size} legs walked {numberOfSteps} steps suggestively");
                return;
            }


            base.Walk(numberOfSteps);
        }
    }
}
