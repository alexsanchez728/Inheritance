using System;

namespace inheritance.Pieces.Legs
{
    abstract class Legbase
    {
        public int PocketCount { get; set; }
        public string Color { get; set; }
        public LegSize Size { get; set; }

        public abstract void Jump(int howHigh);
        // an abstract method MUST be overriden if you inherit it from a class
        // Abstract methods get no body

        public virtual void Walk(int numberOfSteps)
            // a virtual method CAN be overriden if you inherit it from a class
        {
            Console.WriteLine($"The {Size} legs wearing a {GetType().Name} took {numberOfSteps} steps.");
        }
    }
}
