using System;

namespace inheritance.Pieces.Legs
{
    class Shorts : Legbase
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"shorts jumped {howHigh} feet in the air");
        }
    }
}
