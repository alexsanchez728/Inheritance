using System;

namespace inheritance.Pieces.Legs
{
    class Jeans : Legbase
    {
        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Too cool to jump.");
        }
    }
}
