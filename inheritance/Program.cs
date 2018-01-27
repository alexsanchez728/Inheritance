using inheritance.Pieces.Heads;
using inheritance.Pieces.Legs;
using inheritance.Pieces.Torsos;
using System;
using System.Collections.Generic;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var jeans = new Jeans
            {
                Color = "Black",
                Size = LegSize.Adult,
                PocketCount = 6
            };

            var head = new Emmet
            {
                EyeColor = "Blue",
                Happy = true,
                HeadGear = new Hair { Color = "blonde", Length = "Long"}
            };

            var body = new DadBod
            {
                BeerBelly = true,
                BodyHair = true,
                NumberOfNipples = 2,
                Shirt = "purple"
            };

            var dadEmmet = new Minifigure(jeans, head, body, "Emmet");

            dadEmmet.Walk(50);

            Console.ReadKey();
        }
    }
}
