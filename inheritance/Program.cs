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

            var legs = new List<Legbase>
            {
                shorts, skirt, skirt1, jeans, jeans1, jeans2, jeans3
            };

            foreach (var leg in legs)
            {
                leg.Walk(10);
                leg.Jump(10);


                // CASTING

                //if (leg is Skirt)
                //    // bool test first for conversion
                //{
                //  var s = (Skirt)leg;
                //}

                //var s = leg as Skirt;
                //// the results of this conversions into a var
                //// attempt to make leg into a Skirt
                //if (s != null)
                //    // Then it was a skirt
                //{
                //    s.Material
                //}

                //if (leg is Skirt s)
                //// pattern matching - the new cool way to do it, as of 1/2018
                //// make leg into Skirt if you can call it s
                //{
                //    s.Material = "jeans";
                //};

                // pattern matching using switch statements
                switch (leg)
                {
                    case Skirt s:
                        // create s from legBase, a skirt and do this...
                        Console.WriteLine($"its a skirt made of {s.Material}");
                        break;
                    case Jeans j:
                        // create j from legBase, a Jeans and do this...
                        Console.WriteLine($"its {j.Color} jeans");
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}
