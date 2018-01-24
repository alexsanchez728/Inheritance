using System;

namespace inheritance.Pieces.Legs
{
    class Skirt : Legbase
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Skirt jumped {howHigh} inches in the air");
        }

        public override void Walk(int numberOfSteps)
        {
            if (Length == Length.StreetCorner)
            {
                Console.WriteLine($"The {Size} legs walked {numberOfSteps} steps suggestively");
                return;
            }
            base.Walk(numberOfSteps);
        }
    }
}
