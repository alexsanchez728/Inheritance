using inheritance.Pieces.Heads;
using inheritance.Pieces.Legs;
using inheritance.Pieces.Torsos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Minifigure
    {
        public string Name { get; private set; }
        public Legbase Legs { get; private set; }
        public HeadBase Head { get; private set; }
        public TorsoBase Torso { get; private set; }

        public Minifigure(Legbase legs, HeadBase head, TorsoBase torso, string name)
        {
            Legs = legs;
            Head = head;
            Torso = torso;
            Name = name;
        }

        public void Walk(int numberOfSteps)
        {
            switch (Head.HeadGear)
            {
                case Hair hair:
                    Console.WriteLine($"{Name} tossed his {hair.Length} {hair.Color} hair in the wind.");
                    break;
                case Helmet helmet:
                    Console.WriteLine($"{Name} wondered why he is wearing a {helmet.Color} helmat. He is just going on a walk.");
                    break;
            }
            Legs.Walk(numberOfSteps);
        }
    }
}
