using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Pieces.Torsos
{
    class DadBod : TorsoBase
    {
        public bool BeerBelly { get; set; }
        public bool BodyHair { get; set; }
        public int NumberOfNipples { get; set; }
    }
    
    abstract class TorsoBase
    {
        public string Shirt { get; set; } 
    }
}
