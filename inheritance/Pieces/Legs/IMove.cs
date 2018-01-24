using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Pieces.Legs
{

    // an interface can't define what a class does, just how, (and with what)
    // Think of an interface as a "common contract"
    // All parts of an interface must be implimented
    // You can impliment multiple interfaces
    // Anything on an interface is public, always, forever.


    interface IMoveable
    {
        int HowFarIMoved { get; }
        // minimum implimentation of a get

        void Walk(int numberOfSteps);
        void Jump(int howHigh);
        void Run(int howFar);
    }
}
