using inheritance.Pieces.Legs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var shorts = new Shorts { Color = "Tan", Length = Length.Baby, PocketCount = 6 };

            shorts.Walk(20);

            var jeans = new Jeans
            {
                Color = "Black",
                Size = LegSize.Adult,
                PocketCount = 4
            };
            var jeans1 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Baby,
                PocketCount = 4
            };
            var jeans2 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Child,
                PocketCount = 4
            };
            var jeans3 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Adult,
                PocketCount = 6
            };
            var skirt = new Skirt
            {
                Color = "Rainbow",
                Size = LegSize.Child,
                PocketCount = 0,
                Material = "stretchy",
                Length = Length.Church
            };

            var skirt1 = new Skirt
            {
                Color = "Sparkly",
                Size = LegSize.Adult,
                PocketCount = 0,
                Material = "Sequins",
                Length = Length.StreetCorner
            };

            var movers = new List<IMoveable>
            {
                shorts, skirt, skirt1, jeans, jeans1, jeans2, jeans3
            };

            foreach (var mover in movers)
            {
                mover.Walk(10);
                mover.Jump(10);
                mover.Run(20);

                // pattern matching using switch statements
                switch (mover)
                {
                    case Skirt s:
                        // create s from legBase, a skirt and do this...
                        Console.WriteLine($"its a skirt made of {s.Material}");
                        break;
                    case Jeans j:
                        // create j from legBase, a Jeans and do this...
                        Console.WriteLine($"its {j.Color} jeans");
                        break;
                    case IMoveable m:
                        m.Run(20);
                        break;
                }
                //mover.HowFarIMoved = 7;
                // ^ will not work because currently, one instance does not allow a set
            }

            Console.ReadKey();
        }
    }
}
