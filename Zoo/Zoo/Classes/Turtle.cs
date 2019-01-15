using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Turtle : Reptiles
    {
        public override bool LaysEggs { get; set; } = true;
        public override bool IsVenomous { get; set; } = false;
    }
}
