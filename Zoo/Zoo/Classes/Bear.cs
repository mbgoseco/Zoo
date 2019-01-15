using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bear : Mammals
    {
        public override bool LaysEggs { get; set; } = false;
        public override bool IsVenomous { get; set; } = false;
        public override bool GuestsCanFeed { get; set; } = true;

        public abstract string BearHug();
        public override string Speak()
        {
            return "RAR!";
        }
    }
}
