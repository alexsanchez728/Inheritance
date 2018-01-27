using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Pieces.Heads
{
    class Emmet : HeadBase
    {

    }

    abstract class HeadBase
    {
        public string EyeColor { get; set; }
        public bool Happy { get; set; }
        public HeadGear HeadGear { get; set; } 
    }
}
